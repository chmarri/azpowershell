// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Extensions;

    /// <summary>The approval settings.</summary>
    public partial class ApprovalSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal
    {

        /// <summary>Backing field for <see cref="ApprovalMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode? _approvalMode;

        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode? ApprovalMode { get => this._approvalMode; set => this._approvalMode = value; }

        /// <summary>Backing field for <see cref="ApprovalStage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage[] _approvalStage;

        /// <summary>The approval stages of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage[] ApprovalStage { get => this._approvalStage; set => this._approvalStage = value; }

        /// <summary>Backing field for <see cref="IsApprovalRequired" /> property.</summary>
        private bool? _isApprovalRequired;

        /// <summary>Determine whether approval is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public bool? IsApprovalRequired { get => this._isApprovalRequired; set => this._isApprovalRequired = value; }

        /// <summary>Backing field for <see cref="IsApprovalRequiredForExtension" /> property.</summary>
        private bool? _isApprovalRequiredForExtension;

        /// <summary>Determine whether approval is required for assignment extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public bool? IsApprovalRequiredForExtension { get => this._isApprovalRequiredForExtension; set => this._isApprovalRequiredForExtension = value; }

        /// <summary>Backing field for <see cref="IsRequestorJustificationRequired" /> property.</summary>
        private bool? _isRequestorJustificationRequired;

        /// <summary>Determine whether requestor justification required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        public bool? IsRequestorJustificationRequired { get => this._isRequestorJustificationRequired; set => this._isRequestorJustificationRequired = value; }

        /// <summary>Creates an new <see cref="ApprovalSettings" /> instance.</summary>
        public ApprovalSettings()
        {

        }
    }
    /// The approval settings.
    public partial interface IApprovalSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of rule",
        SerializedName = @"approvalMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode? ApprovalMode { get; set; }
        /// <summary>The approval stages of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The approval stages of the request.",
        SerializedName = @"approvalStages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage[] ApprovalStage { get; set; }
        /// <summary>Determine whether approval is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether approval is required or not.",
        SerializedName = @"isApprovalRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsApprovalRequired { get; set; }
        /// <summary>Determine whether approval is required for assignment extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether approval is required for assignment extension.",
        SerializedName = @"isApprovalRequiredForExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Determine whether requestor justification required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether requestor justification required.",
        SerializedName = @"isRequestorJustificationRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsRequestorJustificationRequired { get; set; }

    }
    /// The approval settings.
    internal partial interface IApprovalSettingsInternal

    {
        /// <summary>The type of rule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.ApprovalMode? ApprovalMode { get; set; }
        /// <summary>The approval stages of the request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage[] ApprovalStage { get; set; }
        /// <summary>Determine whether approval is required or not.</summary>
        bool? IsApprovalRequired { get; set; }
        /// <summary>Determine whether approval is required for assignment extension.</summary>
        bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Determine whether requestor justification required.</summary>
        bool? IsRequestorJustificationRequired { get; set; }

    }
}