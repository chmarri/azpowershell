// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Service properties payload</summary>
    public partial class ClusterResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>Fully qualified dns name of the service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.NetworkProfile()); set { {_networkProfile = value;} } }

        /// <summary>Internal Acessors for NetworkProfileOutboundIP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileOutboundIPs Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.NetworkProfileOutboundIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).OutboundIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).OutboundIP = value; }

        /// <summary>Internal Acessors for NetworkProfileRequiredTraffic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IRequiredTraffic[] Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.NetworkProfileRequiredTraffic { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).RequiredTraffic; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).RequiredTraffic = value; }

        /// <summary>Internal Acessors for OutboundIPPublicIP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).OutboundIPPublicIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).OutboundIPPublicIP = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.ServiceId { get => this._serviceId; set { {_serviceId = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IClusterResourcePropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="NetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfile _networkProfile;

        /// <summary>Network profile of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfile NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.NetworkProfile()); set => this._networkProfile = value; }

        /// <summary>
        /// Name of the resource group containing network resources for customer apps in Azure Spring Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string NetworkProfileAppNetworkResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).AppNetworkResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).AppNetworkResourceGroup = value ?? null; }

        /// <summary>
        /// Fully qualified resource Id of the subnet to host customer apps in Azure Spring Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string NetworkProfileAppSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).AppSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).AppSubnetId = value ?? null; }

        /// <summary>Required inbound or outbound traffics for Azure Spring Apps resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IRequiredTraffic[] NetworkProfileRequiredTraffic { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).RequiredTraffic; }

        /// <summary>Azure Spring Apps service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceCidr { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceCidr; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceCidr = value ?? null; }

        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Apps Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceRuntimeNetworkResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceRuntimeNetworkResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceRuntimeNetworkResourceGroup = value ?? null; }

        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Apps Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceRuntimeSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceRuntimeSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).ServiceRuntimeSubnetId = value ?? null; }

        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string[] OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileInternal)NetworkProfile).OutboundIPPublicIP; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServiceId" /> property.</summary>
        private string _serviceId;

        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ServiceId { get => this._serviceId; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private int? _version;

        /// <summary>Version of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public int? Version { get => this._version; }

        /// <summary>Backing field for <see cref="ZoneRedundant" /> property.</summary>
        private bool? _zoneRedundant;

        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public bool? ZoneRedundant { get => this._zoneRedundant; set => this._zoneRedundant = value; }

        /// <summary>Creates an new <see cref="ClusterResourceProperties" /> instance.</summary>
        public ClusterResourceProperties()
        {

        }
    }
    /// Service properties payload
    public partial interface IClusterResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified dns name of the service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified dns name of the service instance",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>
        /// Name of the resource group containing network resources for customer apps in Azure Spring Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group containing network resources for customer apps in Azure Spring Apps",
        SerializedName = @"appNetworkResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileAppNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host customer apps in Azure Spring Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host customer apps in Azure Spring Apps",
        SerializedName = @"appSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileAppSubnetId { get; set; }
        /// <summary>Required inbound or outbound traffics for Azure Spring Apps resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Required inbound or outbound traffics for Azure Spring Apps resource.",
        SerializedName = @"requiredTraffics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IRequiredTraffic) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IRequiredTraffic[] NetworkProfileRequiredTraffic { get;  }
        /// <summary>Azure Spring Apps service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Spring Apps service reserved CIDR",
        SerializedName = @"serviceCidr",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Apps Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group containing network resources of Azure Spring Apps Service Runtime",
        SerializedName = @"serviceRuntimeNetworkResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Apps Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host Azure Spring Apps Service Runtime",
        SerializedName = @"serviceRuntimeSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceRuntimeSubnetId { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of public IP addresses.",
        SerializedName = @"publicIPs",
        PossibleTypes = new [] { typeof(string) })]
        string[] OutboundIPPublicIP { get;  }
        /// <summary>Provisioning state of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Service",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ServiceInstanceEntity GUID which uniquely identifies a created resource",
        SerializedName = @"serviceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceId { get;  }
        /// <summary>Version of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the Service",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? Version { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"zoneRedundant",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZoneRedundant { get; set; }

    }
    /// Service properties payload
    internal partial interface IClusterResourcePropertiesInternal

    {
        /// <summary>Fully qualified dns name of the service instance</summary>
        string Fqdn { get; set; }
        /// <summary>Network profile of the Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfile NetworkProfile { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources for customer apps in Azure Spring Apps
        /// </summary>
        string NetworkProfileAppNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host customer apps in Azure Spring Apps
        /// </summary>
        string NetworkProfileAppSubnetId { get; set; }
        /// <summary>Desired outbound IP resources for Azure Spring Apps resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileOutboundIPs NetworkProfileOutboundIP { get; set; }
        /// <summary>Required inbound or outbound traffics for Azure Spring Apps resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IRequiredTraffic[] NetworkProfileRequiredTraffic { get; set; }
        /// <summary>Azure Spring Apps service reserved CIDR</summary>
        string NetworkProfileServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Apps Service Runtime
        /// </summary>
        string NetworkProfileServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Apps Service Runtime
        /// </summary>
        string NetworkProfileServiceRuntimeSubnetId { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        string[] OutboundIPPublicIP { get; set; }
        /// <summary>Provisioning state of the Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        string ServiceId { get; set; }
        /// <summary>Version of the Service</summary>
        int? Version { get; set; }

        bool? ZoneRedundant { get; set; }

    }
}