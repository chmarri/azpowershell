// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>
    /// Additional settings for the VM app that contains the target package and config file name when it is deployed to target
    /// VM or VM scale set.
    /// </summary>
    public partial class UserArtifactSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IUserArtifactSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IUserArtifactSettingsInternal
    {

        /// <summary>Backing field for <see cref="ConfigFileName" /> property.</summary>
        private string _configFileName;

        /// <summary>
        /// Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified,
        /// the config file will be named the Gallery Application name appended with "_config".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string ConfigFileName { get => this._configFileName; set => this._configFileName = value; }

        /// <summary>Backing field for <see cref="PackageFileName" /> property.</summary>
        private string _packageFileName;

        /// <summary>
        /// Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified,
        /// the package file will be named the same as the Gallery Application name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string PackageFileName { get => this._packageFileName; set => this._packageFileName = value; }

        /// <summary>Creates an new <see cref="UserArtifactSettings" /> instance.</summary>
        public UserArtifactSettings()
        {

        }
    }
    /// Additional settings for the VM app that contains the target package and config file name when it is deployed to target
    /// VM or VM scale set.
    public partial interface IUserArtifactSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified,
        /// the config file will be named the Gallery Application name appended with "_config".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified, the config file will be named the Gallery Application name appended with ""_config"".",
        SerializedName = @"configFileName",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigFileName { get; set; }
        /// <summary>
        /// Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified,
        /// the package file will be named the same as the Gallery Application name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified, the package file will be named the same as the Gallery Application name.",
        SerializedName = @"packageFileName",
        PossibleTypes = new [] { typeof(string) })]
        string PackageFileName { get; set; }

    }
    /// Additional settings for the VM app that contains the target package and config file name when it is deployed to target
    /// VM or VM scale set.
    internal partial interface IUserArtifactSettingsInternal

    {
        /// <summary>
        /// Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified,
        /// the config file will be named the Gallery Application name appended with "_config".
        /// </summary>
        string ConfigFileName { get; set; }
        /// <summary>
        /// Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified,
        /// the package file will be named the same as the Gallery Application name.
        /// </summary>
        string PackageFileName { get; set; }

    }
}