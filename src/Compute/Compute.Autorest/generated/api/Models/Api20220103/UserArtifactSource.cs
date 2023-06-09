// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>The source image from which the Image Version is going to be created.</summary>
    public partial class UserArtifactSource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IUserArtifactSource,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IUserArtifactSourceInternal
    {

        /// <summary>Backing field for <see cref="DefaultConfigurationLink" /> property.</summary>
        private string _defaultConfigurationLink;

        /// <summary>
        /// Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string DefaultConfigurationLink { get => this._defaultConfigurationLink; set => this._defaultConfigurationLink = value; }

        /// <summary>Backing field for <see cref="MediaLink" /> property.</summary>
        private string _mediaLink;

        /// <summary>Required. The mediaLink of the artifact, must be a readable storage page blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string MediaLink { get => this._mediaLink; set => this._mediaLink = value; }

        /// <summary>Creates an new <see cref="UserArtifactSource" /> instance.</summary>
        public UserArtifactSource()
        {

        }
    }
    /// The source image from which the Image Version is going to be created.
    public partial interface IUserArtifactSource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob.",
        SerializedName = @"defaultConfigurationLink",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultConfigurationLink { get; set; }
        /// <summary>Required. The mediaLink of the artifact, must be a readable storage page blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Required. The mediaLink of the artifact, must be a readable storage page blob.",
        SerializedName = @"mediaLink",
        PossibleTypes = new [] { typeof(string) })]
        string MediaLink { get; set; }

    }
    /// The source image from which the Image Version is going to be created.
    internal partial interface IUserArtifactSourceInternal

    {
        /// <summary>
        /// Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob.
        /// </summary>
        string DefaultConfigurationLink { get; set; }
        /// <summary>Required. The mediaLink of the artifact, must be a readable storage page blob.</summary>
        string MediaLink { get; set; }

    }
}