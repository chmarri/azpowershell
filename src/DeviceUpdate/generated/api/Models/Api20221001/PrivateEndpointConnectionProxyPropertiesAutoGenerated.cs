// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Private endpoint connection proxy object properties.</summary>
    public partial class PrivateEndpointConnectionProxyPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>ETag from NRP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for RemotePrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal.RemotePrivateEndpoint { get => (this._remotePrivateEndpoint = this._remotePrivateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.RemotePrivateEndpoint()); set { {_remotePrivateEndpoint = value;} } }

        /// <summary>Backing field for <see cref="RemotePrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpoint _remotePrivateEndpoint;

        /// <summary>Remote private endpoint details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpoint RemotePrivateEndpoint { get => (this._remotePrivateEndpoint = this._remotePrivateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.RemotePrivateEndpoint()); set => this._remotePrivateEndpoint = value; }

        /// <summary>List of connection details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IConnectionDetails[] RemotePrivateEndpointConnectionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ConnectionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ConnectionDetail = value ?? null /* arrayOf */; }

        /// <summary>Remote endpoint resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Id = value ?? null; }

        /// <summary>Original resource ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointImmutableResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ImmutableResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ImmutableResourceId = value ?? null; }

        /// <summary>Original subscription ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointImmutableSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ImmutableSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ImmutableSubscriptionId = value ?? null; }

        /// <summary>ARM location of the remote private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Location = value ?? null; }

        /// <summary>List of private link service connections that need manual approval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointManualPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ManualPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ManualPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>List of automatically approved private link service connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>List of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceProxy[] RemotePrivateEndpointPrivateLinkServiceProxy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceProxy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceProxy = value ?? null /* arrayOf */; }

        /// <summary>Virtual network traffic tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointVnetTrafficTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).VnetTrafficTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).VnetTrafficTag = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>
        /// Creates an new <see cref="PrivateEndpointConnectionProxyPropertiesAutoGenerated" /> instance.
        /// </summary>
        public PrivateEndpointConnectionProxyPropertiesAutoGenerated()
        {

        }
    }
    /// Private endpoint connection proxy object properties.
    public partial interface IPrivateEndpointConnectionProxyPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable
    {
        /// <summary>ETag from NRP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ETag from NRP.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get;  }
        /// <summary>List of connection details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of connection details.",
        SerializedName = @"connectionDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IConnectionDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IConnectionDetails[] RemotePrivateEndpointConnectionDetail { get; set; }
        /// <summary>Remote endpoint resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Remote endpoint resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointId { get; set; }
        /// <summary>Original resource ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Original resource ID needed by Microsoft.Network.",
        SerializedName = @"immutableResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointImmutableResourceId { get; set; }
        /// <summary>Original subscription ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Original subscription ID needed by Microsoft.Network.",
        SerializedName = @"immutableSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointImmutableSubscriptionId { get; set; }
        /// <summary>ARM location of the remote private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM location of the remote private endpoint.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointLocation { get; set; }
        /// <summary>List of private link service connections that need manual approval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private link service connections that need manual approval.",
        SerializedName = @"manualPrivateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointManualPrivateLinkServiceConnection { get; set; }
        /// <summary>List of automatically approved private link service connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of automatically approved private link service connections.",
        SerializedName = @"privateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointPrivateLinkServiceConnection { get; set; }
        /// <summary>List of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private link service proxies.",
        SerializedName = @"privateLinkServiceProxies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceProxy) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceProxy[] RemotePrivateEndpointPrivateLinkServiceProxy { get; set; }
        /// <summary>Virtual network traffic tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Virtual network traffic tag.",
        SerializedName = @"vnetTrafficTag",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointVnetTrafficTag { get; set; }
        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Private endpoint connection proxy object properties.
    internal partial interface IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal

    {
        /// <summary>ETag from NRP.</summary>
        string ETag { get; set; }
        /// <summary>Remote private endpoint details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpoint RemotePrivateEndpoint { get; set; }
        /// <summary>List of connection details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IConnectionDetails[] RemotePrivateEndpointConnectionDetail { get; set; }
        /// <summary>Remote endpoint resource ID.</summary>
        string RemotePrivateEndpointId { get; set; }
        /// <summary>Original resource ID needed by Microsoft.Network.</summary>
        string RemotePrivateEndpointImmutableResourceId { get; set; }
        /// <summary>Original subscription ID needed by Microsoft.Network.</summary>
        string RemotePrivateEndpointImmutableSubscriptionId { get; set; }
        /// <summary>ARM location of the remote private endpoint.</summary>
        string RemotePrivateEndpointLocation { get; set; }
        /// <summary>List of private link service connections that need manual approval.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointManualPrivateLinkServiceConnection { get; set; }
        /// <summary>List of automatically approved private link service connections.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointPrivateLinkServiceConnection { get; set; }
        /// <summary>List of private link service proxies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceProxy[] RemotePrivateEndpointPrivateLinkServiceProxy { get; set; }
        /// <summary>Virtual network traffic tag.</summary>
        string RemotePrivateEndpointVnetTrafficTag { get; set; }
        /// <summary>Operation status.</summary>
        string Status { get; set; }

    }
}