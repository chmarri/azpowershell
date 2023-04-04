// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    /// <summary>Properties of NSP profile.</summary>
    public partial class NspProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccessRulesVersion" /> property.</summary>
        private string _accessRulesVersion;

        /// <summary>
        /// Version number that increases with every update to access rules within the profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string AccessRulesVersion { get => this._accessRulesVersion; }

        /// <summary>Backing field for <see cref="DiagnosticSettingsVersion" /> property.</summary>
        private string _diagnosticSettingsVersion;

        /// <summary>
        /// Version number that increases with every update to diagnostic settings within the profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string DiagnosticSettingsVersion { get => this._diagnosticSettingsVersion; }

        /// <summary>Internal Acessors for AccessRulesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfilePropertiesInternal.AccessRulesVersion { get => this._accessRulesVersion; set { {_accessRulesVersion = value;} } }

        /// <summary>Internal Acessors for DiagnosticSettingsVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspProfilePropertiesInternal.DiagnosticSettingsVersion { get => this._diagnosticSettingsVersion; set { {_diagnosticSettingsVersion = value;} } }

        /// <summary>Creates an new <see cref="NspProfileProperties" /> instance.</summary>
        public NspProfileProperties()
        {

        }
    }
    /// Properties of NSP profile.
    public partial interface INspProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Version number that increases with every update to access rules within the profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version number that increases with every update to access rules within the profile.",
        SerializedName = @"accessRulesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AccessRulesVersion { get;  }
        /// <summary>
        /// Version number that increases with every update to diagnostic settings within the profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version number that increases with every update to diagnostic settings within the profile.",
        SerializedName = @"diagnosticSettingsVersion",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticSettingsVersion { get;  }

    }
    /// Properties of NSP profile.
    internal partial interface INspProfilePropertiesInternal

    {
        /// <summary>
        /// Version number that increases with every update to access rules within the profile.
        /// </summary>
        string AccessRulesVersion { get; set; }
        /// <summary>
        /// Version number that increases with every update to diagnostic settings within the profile.
        /// </summary>
        string DiagnosticSettingsVersion { get; set; }

    }
}