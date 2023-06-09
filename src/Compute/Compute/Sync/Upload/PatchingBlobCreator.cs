// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.Sync.Download;
using Microsoft.WindowsAzure.Commands.Tools.Vhd;
using Microsoft.WindowsAzure.Commands.Tools.Vhd.Model.Persistence;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Microsoft.WindowsAzure.Commands.Sync.Upload
{
    public class PatchingBlobCreator : BlobCreatorBase
    {
        protected Uri baseVhdBlob;
        protected BlobUri baseVhdBlobUri;

        public PatchingBlobCreator(FileInfo localVhd, BlobUri destination, BlobUri baseVhdBlob, ICloudPageBlobObjectFactory blobObjectFactory, bool overWrite) :
            base(localVhd, destination, blobObjectFactory, overWrite)
        {
            this.baseVhdBlob = baseVhdBlob.Uri;
            this.baseVhdBlobUri = baseVhdBlob;
        }


        protected override void CreateRemoteBlobAndPopulateContext(UploadContext context)
        {
            CreateRemoteBlob();
            PopulateContextWithUploadableRanges(localVhd, context, true);
            PopulateContextWithDataToUpload(localVhd, context);
        }

        private void CreateRemoteBlob()
        {
            var baseBlob = this.blobObjectFactory.Create(baseVhdBlobUri);

            if (!baseBlob.Exists())
            {
                throw new InvalidOperationException(String.Format("Base image to patch doesn't exist in blob storage: {0}", baseVhdBlobUri.Uri));
            }
            var blobVhdFooter = baseBlob.GetVhdFooter();

            long blobSize;
            VhdFilePath localBaseVhdPath;
            IEnumerable<Guid> childrenVhdIds;
            using (var vhdFile = new VhdFileFactory().Create(localVhd.FullName))
            {
                localBaseVhdPath = vhdFile.GetFilePathBy(blobVhdFooter.UniqueId);
                childrenVhdIds = vhdFile.GetChildrenIds(blobVhdFooter.UniqueId).ToArray();
                blobSize = vhdFile.Footer.CurrentSize;
            }

            FileMetaData fileMetaData = GetFileMetaData(baseBlob, localBaseVhdPath);

            var md5Hash = baseBlob.GetBlobMd5Hash();
            if (!md5Hash.SequenceEqual(fileMetaData.MD5Hash))
            {
                var message = String.Format("Patching cannot proceed, MD5 hash of base image in blob storage ({0}) and base VHD file ({1}) does not match ",
                                            baseBlob.Uri,
                                            localBaseVhdPath);
                throw new InvalidOperationException(message);
            }

            Program.SyncOutput.MessageCreatingNewPageBlob(blobSize);

            CopyBaseImageToDestination();

            using (var vds = new VirtualDiskStream(localVhd.FullName))
            {
                var streamExtents = vds.Extents.ToArray();
                var enumerable = streamExtents.Where(e => childrenVhdIds.Contains(e.Owner)).ToArray();
                foreach (var streamExtent in enumerable)
                {
                    var indexRange = streamExtent.Range;
                    destinationBlob.ClearPagesAsync(indexRange.StartIndex, indexRange.Length)
                        .ConfigureAwait(false).GetAwaiter().GetResult();
                }
            }

            using (var bmds = new BlobMetaDataScope(destinationBlob))
            {
                bmds.Current.RemoveBlobMd5Hash();
                bmds.Current.SetUploadMetaData(OperationMetaData);
                bmds.Complete();
            }
        }

        private void CopyBaseImageToDestination()
        {
            var source = this.blobObjectFactory.Create(baseVhdBlobUri);
            source.FetchAttributesAsync()
                .ConfigureAwait(false).GetAwaiter().GetResult();

            var copyStatus = new ProgressStatus(0, source.Properties.Length);
            using (ProgressTracker progressTracker = new ProgressTracker(copyStatus, Program.SyncOutput.ProgressCopyStatus, Program.SyncOutput.ProgressCopyComplete))
            {
                destinationBlob.StartCopyAsync(source).ConfigureAwait(false).GetAwaiter().GetResult();
                destinationBlob.FetchAttributesAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                while (true)
                {
                    if (destinationBlob.CopyState.BytesCopied != null)
                    {
                        copyStatus.AddToProcessedBytes(destinationBlob.CopyState.BytesCopied.Value - copyStatus.BytesProcessed);
                    }
                    if (destinationBlob.CopyState.Status == CopyStatus.Success)
                    {
                        break;
                    }
                    if (destinationBlob.CopyState.Status == CopyStatus.Pending)
                    {
                        progressTracker.Update();
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                    else
                    {
                        throw new ApplicationException(
                            string.Format("Cannot copy source '{0}' to destination '{1}', copy state is '{2}'", source.Uri,
                                          destinationBlob.Uri, destinationBlob.CopyState));
                    }
                    destinationBlob.FetchAttributesAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                }
            }
        }

        private FileMetaData GetFileMetaData(CloudPageBlob baseBlob, VhdFilePath localBaseVhdPath)
        {
            FileMetaData fileMetaData;
            if (File.Exists(localBaseVhdPath.AbsolutePath))
            {
                fileMetaData = FileMetaData.Create(localBaseVhdPath.AbsolutePath);
            }
            else
            {
                var filePath = Path.Combine(localVhd.Directory.FullName, localBaseVhdPath.RelativePath);
                if (File.Exists(filePath))
                {
                    fileMetaData = FileMetaData.Create(filePath);
                }
                else
                {
                    var message = String.Format("Cannot find the local base image for '{0}' in neither of the locations '{1}', '{2}'.",
                                                baseBlob.Uri,
                                                localBaseVhdPath.AbsolutePath,
                                                localBaseVhdPath.RelativePath);
                    throw new InvalidOperationException(message);
                }
            }
            return fileMetaData;
        }
    }

    class BlobMetaDataScope : IDisposable
    {
        private readonly CloudPageBlob blob;
        private bool disposed;
        private bool completed;

        public BlobMetaDataScope(CloudPageBlob blob)
        {
            this.blob = blob;
            this.blob.FetchAttributesAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            this.Current = blob;
        }

        public CloudPageBlob Current { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!this.disposed)
                {
                    if (completed)
                    {
                        this.blob.SetMetadataAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                        this.blob.SetPropertiesAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    }
                    this.disposed = true;
                }
            }
        }

        public void Complete()
        {
            this.completed = true;
        }
    }
}