// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Specifies information about the gallery sharing profile update.</summary>
    public partial class SharingUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingUpdateInternal
    {

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingProfileGroup[] _group;

        /// <summary>A list of sharing profile groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingProfileGroup[] Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingUpdateOperationTypes _operationType;

        /// <summary>
        /// This property allows you to specify the operation type of gallery sharing update. <br><br> Possible values are: <br><br>
        /// **Add** <br><br> **Remove** <br><br> **Reset**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingUpdateOperationTypes OperationType { get => this._operationType; set => this._operationType = value; }

        /// <summary>Creates an new <see cref="SharingUpdate" /> instance.</summary>
        public SharingUpdate()
        {

        }
    }
    /// Specifies information about the gallery sharing profile update.
    public partial interface ISharingUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>A list of sharing profile groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of sharing profile groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingProfileGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingProfileGroup[] Group { get; set; }
        /// <summary>
        /// This property allows you to specify the operation type of gallery sharing update. <br><br> Possible values are: <br><br>
        /// **Add** <br><br> **Remove** <br><br> **Reset**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"This property allows you to specify the operation type of gallery sharing update. <br><br> Possible values are: <br><br> **Add** <br><br> **Remove** <br><br> **Reset**",
        SerializedName = @"operationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingUpdateOperationTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingUpdateOperationTypes OperationType { get; set; }

    }
    /// Specifies information about the gallery sharing profile update.
    internal partial interface ISharingUpdateInternal

    {
        /// <summary>A list of sharing profile groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ISharingProfileGroup[] Group { get; set; }
        /// <summary>
        /// This property allows you to specify the operation type of gallery sharing update. <br><br> Possible values are: <br><br>
        /// **Add** <br><br> **Remove** <br><br> **Reset**
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingUpdateOperationTypes OperationType { get; set; }

    }
}