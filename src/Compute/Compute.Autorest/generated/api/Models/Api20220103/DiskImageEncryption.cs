// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>This is the disk image encryption base class.</summary>
    public partial class DiskImageEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDiskImageEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDiskImageEncryptionInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Creates an new <see cref="DiskImageEncryption" /> instance.</summary>
        public DiskImageEncryption()
        {

        }
    }
    /// This is the disk image encryption base class.
    public partial interface IDiskImageEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A relative URI containing the resource ID of the disk encryption set.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }

    }
    /// This is the disk image encryption base class.
    internal partial interface IDiskImageEncryptionInternal

    {
        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        string DiskEncryptionSetId { get; set; }

    }
}