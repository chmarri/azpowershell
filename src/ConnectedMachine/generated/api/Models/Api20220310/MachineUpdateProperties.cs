// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Describes the ARM updatable properties of a hybrid machine.</summary>
    public partial class MachineUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="CloudMetadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadata _cloudMetadata;

        /// <summary>The metadata of the cloud environment (Azure/GCP/AWS/OCI...).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadata CloudMetadata { get => (this._cloudMetadata = this._cloudMetadata ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.CloudMetadata()); set => this._cloudMetadata = value; }

        /// <summary>Specifies the cloud provider (Azure/AWS/GCP...).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string CloudMetadataProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadataInternal)CloudMetadata).Provider; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? LinuxConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSettingsAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSettingsAssessmentMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes)""); }

        /// <summary>Specifies the patch mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? LinuxConfigurationPatchSettingsPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSettingsPatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSettingsPatchMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes)""); }

        /// <summary>Backing field for <see cref="LocationData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationData _locationData;

        /// <summary>Metadata pertaining to the geographic location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationData LocationData { get => (this._locationData = this._locationData ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.LocationData()); set => this._locationData = value; }

        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string LocationDataCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).City = value ?? null; }

        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string LocationDataCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).CountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).CountryOrRegion = value ?? null; }

        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string LocationDataDistrict { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).District; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).District = value ?? null; }

        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string LocationDataName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationDataInternal)LocationData).Name = value ?? null; }

        /// <summary>Internal Acessors for CloudMetadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadata Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.CloudMetadata { get => (this._cloudMetadata = this._cloudMetadata ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.CloudMetadata()); set { {_cloudMetadata = value;} } }

        /// <summary>Internal Acessors for CloudMetadataProvider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.CloudMetadataProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadataInternal)CloudMetadata).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadataInternal)CloudMetadata).Provider = value; }

        /// <summary>Internal Acessors for LinuxConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.LinuxConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfigurationPatchSetting = value; }

        /// <summary>Internal Acessors for LocationData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationData Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.LocationData { get => (this._locationData = this._locationData ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.LocationData()); set { {_locationData = value;} } }

        /// <summary>Internal Acessors for OSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.OSProfile()); set { {_oSProfile = value;} } }

        /// <summary>Internal Acessors for OSProfileComputerName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).ComputerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).ComputerName = value; }

        /// <summary>Internal Acessors for OSProfileLinuxConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileLinuxConfiguration Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.OSProfileLinuxConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).LinuxConfiguration = value; }

        /// <summary>Internal Acessors for OSProfileWindowsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileWindowsConfiguration Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.OSProfileWindowsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfiguration = value; }

        /// <summary>Internal Acessors for WindowConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdatePropertiesInternal.WindowConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowConfigurationPatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowConfigurationPatchSetting = value; }

        /// <summary>Backing field for <see cref="OSProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfile _oSProfile;

        /// <summary>Specifies the operating system settings for the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfile OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.OSProfile()); set => this._oSProfile = value; }

        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).ComputerName; }

        /// <summary>Backing field for <see cref="ParentClusterResourceId" /> property.</summary>
        private string _parentClusterResourceId;

        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ParentClusterResourceId { get => this._parentClusterResourceId; set => this._parentClusterResourceId = value; }

        /// <summary>Backing field for <see cref="PrivateLinkScopeResourceId" /> property.</summary>
        private string _privateLinkScopeResourceId;

        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string PrivateLinkScopeResourceId { get => this._privateLinkScopeResourceId; set => this._privateLinkScopeResourceId = value; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? WindowsConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfigurationPatchSettingsAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfigurationPatchSettingsAssessmentMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes)""); }

        /// <summary>Specifies the patch mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? WindowsConfigurationPatchSettingsPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfigurationPatchSettingsPatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileInternal)OSProfile).WindowsConfigurationPatchSettingsPatchMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes)""); }

        /// <summary>Creates an new <see cref="MachineUpdateProperties" /> instance.</summary>
        public MachineUpdateProperties()
        {

        }
    }
    /// Describes the ARM updatable properties of a hybrid machine.
    public partial interface IMachineUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the cloud provider (Azure/AWS/GCP...).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the cloud provider (Azure/AWS/GCP...).",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string CloudMetadataProvider { get;  }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the patch mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the patch mode.",
        SerializedName = @"patchMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? LinuxConfigurationPatchSettingsPatchMode { get; set; }
        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The city or locality where the resource is located.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The country or region where the resource is located",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The district, state, or province where the resource is located.",
        SerializedName = @"district",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A canonical name for the geographic or physical location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataName { get; set; }
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the host OS name of the hybrid machine.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileComputerName { get;  }
        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.",
        SerializedName = @"parentClusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ParentClusterResourceId { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the private link scope this machine is assigned to, if any.",
        SerializedName = @"privateLinkScopeResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeResourceId { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? WindowsConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the patch mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the patch mode.",
        SerializedName = @"patchMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? WindowsConfigurationPatchSettingsPatchMode { get; set; }

    }
    /// Describes the ARM updatable properties of a hybrid machine.
    internal partial interface IMachineUpdatePropertiesInternal

    {
        /// <summary>The metadata of the cloud environment (Azure/GCP/AWS/OCI...).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.ICloudMetadata CloudMetadata { get; set; }
        /// <summary>Specifies the cloud provider (Azure/AWS/GCP...).</summary>
        string CloudMetadataProvider { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IPatchSettings LinuxConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the patch mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? LinuxConfigurationPatchSettingsPatchMode { get; set; }
        /// <summary>Metadata pertaining to the geographic location of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ILocationData LocationData { get; set; }
        /// <summary>The city or locality where the resource is located.</summary>
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        string LocationDataName { get; set; }
        /// <summary>Specifies the operating system settings for the hybrid machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfile OSProfile { get; set; }
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        string OSProfileComputerName { get; set; }
        /// <summary>Specifies the linux configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileLinuxConfiguration OSProfileLinuxConfiguration { get; set; }
        /// <summary>Specifies the windows configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IOSProfileWindowsConfiguration OSProfileWindowsConfiguration { get; set; }
        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        string ParentClusterResourceId { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        string PrivateLinkScopeResourceId { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IPatchSettings WindowConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes? WindowsConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the patch mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes? WindowsConfigurationPatchSettingsPatchMode { get; set; }

    }
}