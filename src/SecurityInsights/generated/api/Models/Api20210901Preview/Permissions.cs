// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Permissions required for the connector</summary>
    public partial class Permissions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IPermissions,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IPermissionsInternal
    {

        /// <summary>Backing field for <see cref="Custom" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICustomsPermission[] _custom;

        /// <summary>Customs permissions required for the connector</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICustomsPermission[] Custom { get => this._custom; set => this._custom = value; }

        /// <summary>Backing field for <see cref="ResourceProvider" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IResourceProvider[] _resourceProvider;

        /// <summary>Resource provider permissions required for the connector</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IResourceProvider[] ResourceProvider { get => this._resourceProvider; set => this._resourceProvider = value; }

        /// <summary>Creates an new <see cref="Permissions" /> instance.</summary>
        public Permissions()
        {

        }
    }
    /// Permissions required for the connector
    public partial interface IPermissions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Customs permissions required for the connector</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customs permissions required for the connector",
        SerializedName = @"customs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICustomsPermission) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICustomsPermission[] Custom { get; set; }
        /// <summary>Resource provider permissions required for the connector</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource provider permissions required for the connector",
        SerializedName = @"resourceProvider",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IResourceProvider) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IResourceProvider[] ResourceProvider { get; set; }

    }
    /// Permissions required for the connector
    internal partial interface IPermissionsInternal

    {
        /// <summary>Customs permissions required for the connector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICustomsPermission[] Custom { get; set; }
        /// <summary>Resource provider permissions required for the connector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IResourceProvider[] ResourceProvider { get; set; }

    }
}