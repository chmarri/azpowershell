﻿// ----------------------------------------------------------------------------------
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
using Microsoft.Azure.Commands.Common.Authentication.Properties;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Threading;

namespace Microsoft.Azure.Commands.ResourceManager.Common
{
    class StorageWrapper : IStorage
    { 
        private const string KeyChainServiceName = "Microsoft.Azure.PowerShell";

        public string FileName { get; set; }
        public string Directory { get; set; }

        private Exception _lastError;

        private Storage _storage = null;

        static ReaderWriterLockSlim storageLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        public StorageWrapper()
        {

        }

        public IStorage Create()
        {
            StorageCreationPropertiesBuilder storageProperties = null;
            if (!storageLock.TryEnterWriteLock(TimeSpan.Zero))
            {
                throw new InvalidOperationException(Resources.StorageLockConflicts);
            }
            try
            {
                storageProperties = new StorageCreationPropertiesBuilder(FileName, Directory)
                    .WithMacKeyChain(KeyChainServiceName + ".other_secrets", FileName)
                    .WithLinuxUnprotectedFile();
                _storage = Storage.Create(storageProperties.Build());
                VerifyPersistence();
            }
            catch (MsalCachePersistenceException e)
            {
                _lastError = e;
                _storage.Clear();
                storageProperties = new StorageCreationPropertiesBuilder(FileName, Directory).WithUnprotectedFile();
                _storage = Storage.Create(storageProperties.Build());
            }
            finally
            {
                storageLock.ExitWriteLock();
            }
            return this;
        }

        public void Clear()
        {
            if (!storageLock.TryEnterWriteLock(TimeSpan.Zero))
            {
                throw new InvalidOperationException(Resources.StorageLockConflicts);
            }
            try
            {
                _storage.Clear();
            }
            finally
            {
                storageLock.ExitWriteLock();
            }
        }

        public byte[] ReadData()
        {
            if (!storageLock.TryEnterReadLock(TimeSpan.Zero))
            {
                throw new InvalidOperationException(Resources.StorageLockConflicts);
            }
            try
            {
                return _storage.ReadData();
            }
            finally
            {
                storageLock.ExitReadLock();
            }
        }

        public void VerifyPersistence()
        {
            if (!storageLock.TryEnterWriteLock(TimeSpan.Zero))
            {
                throw new InvalidOperationException(Resources.StorageLockConflicts);
            }
            try
            {
                _storage.VerifyPersistence();
            }
            finally
            {
                storageLock.ExitWriteLock();
            }
        }

        public void WriteData(byte[] data)
        {
            if (!storageLock.TryEnterWriteLock(TimeSpan.Zero))
            {
                throw new InvalidOperationException(Resources.StorageLockConflicts);
            }

            try
            {
                _storage.WriteData(data);
            }
            finally
            {
                storageLock.ExitWriteLock();
            }
        }

        public Exception GetLastError()
        {
            return _lastError;
        }
    }
}
