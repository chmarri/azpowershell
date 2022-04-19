//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssStorageProfile", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class SetAzureRmVmssStorageProfileCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        protected const string DiffDiskPlacementPresentButNotSetting = "The DiffDiskPlacement parameter can only be used when the DiffDiskSetting parameter is set to 'Local'. Please provide the DiffDiskSetting parameter.";

        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferencePublisher { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceOffer { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceSku { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        [Alias("Name")]
        public string OsDiskName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public CachingTypes? OsDiskCaching { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public string OsDiskCreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsDiskOsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public string Image { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public string[] VhdContainer { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [ResourceIdCompleter("Microsoft.Compute galleries/images/versions")]
        public string ImageReferenceId { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter OsDiskWriteAccelerator { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiffDiskSetting { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Specifies the ephemeral disk placement for operating system disk. This property can be used by user in the request to choose the location i.e. cache disk or resource disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer Ephemeral OS disk size requirements for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. This parameter can only be used if the parameter DiffDiskSetting is set to 'Local'.")]
        [PSArgumentCompleter("CacheDisk", "ResourceDisk")]
        public string DiffDiskPlacement { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string ManagedDisk { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiskEncryptionSetId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetDataDisk[] DataDisk { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            if (this.IsParameterBound(c => c.ImageReferencePublisher))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Publisher = this.ImageReferencePublisher;
            }

            if (this.IsParameterBound(c => c.ImageReferenceOffer))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Offer = this.ImageReferenceOffer;
            }

            if (this.IsParameterBound(c => c.ImageReferenceSku))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Sku = this.ImageReferenceSku;
            }

            if (this.IsParameterBound(c => c.ImageReferenceVersion))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Version = this.ImageReferenceVersion;
            }

            if (this.IsParameterBound(c => c.ImageReferenceId))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Id = this.ImageReferenceId;
            }

            if (this.IsParameterBound(c => c.OsDiskName))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Name = this.OsDiskName;
            }

            if (this.IsParameterBound(c => c.OsDiskCaching))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Caching = this.OsDiskCaching;
            }

            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
            }
            // StorageProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
            }
            // OsDisk
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
            }
            this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.WriteAcceleratorEnabled = this.OsDiskWriteAccelerator.IsPresent;

            if (this.IsParameterBound(c => c.OsDiskCreateOption))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.CreateOption = this.OsDiskCreateOption;
            }

            if (this.IsParameterBound(c => c.DiffDiskPlacement) & !this.IsParameterBound(c => c.DiffDiskPlacement))
            {
                WriteError(new ErrorRecord(
                        new Exception(DiffDiskPlacementPresentButNotSetting),
                        string.Empty, ErrorCategory.InvalidArgument, null));
            }

            // DiffDiskSetting
            if (this.IsParameterBound(c => c.DiffDiskSetting))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // DiffDiskSettings.Option
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings = new DiffDiskSettings();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings.Option = this.DiffDiskSetting;

                // DiffDiskPlacement assignment
                if (this.IsParameterBound(c => c.DiffDiskPlacement))
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings.Placement = this.DiffDiskPlacement;
                }
            }

            if (this.IsParameterBound(c => c.OsDiskOsType))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.OsType = this.OsDiskOsType;
            }

            if (this.IsParameterBound(c => c.Image))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // Image
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image = new VirtualHardDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image.Uri = this.Image;
            }

            if (this.IsParameterBound(c => c.VhdContainer))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.VhdContainers = this.VhdContainer;
            }

            if (this.IsParameterBound(c => c.ManagedDisk))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // ManagedDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk.StorageAccountType = this.ManagedDisk;
            }

            if (this.IsParameterBound(c => c.DiskEncryptionSetId))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // ManagedDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters();
                }
                // DiskEncryptionSet
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk.DiskEncryptionSet == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk.DiskEncryptionSet = new DiskEncryptionSetParameters();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk.DiskEncryptionSet.Id = this.DiskEncryptionSetId;
            }

            if (this.IsParameterBound(c => c.DataDisk))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.DataDisks = this.DataDisk;
            }

            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
