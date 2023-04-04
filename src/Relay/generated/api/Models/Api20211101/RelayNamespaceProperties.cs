// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Extensions;

    /// <summary>Properties of the namespace.</summary>
    public partial class RelayNamespaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespaceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>The time the namespace was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="MetricId" /> property.</summary>
        private string _metricId;

        /// <summary>Identifier for Azure Insights metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string MetricId { get => this._metricId; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for MetricId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.MetricId { get => this._metricId; set { {_metricId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceBusEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.ServiceBusEndpoint { get => this._serviceBusEndpoint; set { {_serviceBusEndpoint = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for UpdatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespacePropertiesInternal.UpdatedAt { get => this._updatedAt; set { {_updatedAt = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IPrivateEndpointConnection[] _privateEndpointConnection;

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IPrivateEndpointConnection[] PrivateEndpointConnection { get => this._privateEndpointConnection; set => this._privateEndpointConnection = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the Namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PublicNetworkAccess? _publicNetworkAccess;

        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PublicNetworkAccess? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ServiceBusEndpoint" /> property.</summary>
        private string _serviceBusEndpoint;

        /// <summary>Endpoint you can use to perform Service Bus operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string ServiceBusEndpoint { get => this._serviceBusEndpoint; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the Namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="UpdatedAt" /> property.</summary>
        private global::System.DateTime? _updatedAt;

        /// <summary>The time the namespace was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public global::System.DateTime? UpdatedAt { get => this._updatedAt; }

        /// <summary>Creates an new <see cref="RelayNamespaceProperties" /> instance.</summary>
        public RelayNamespaceProperties()
        {

        }
    }
    /// Properties of the namespace.
    public partial interface IRelayNamespaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IJsonSerializable
    {
        /// <summary>The time the namespace was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time the namespace was created.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>Identifier for Azure Insights metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Identifier for Azure Insights metrics.",
        SerializedName = @"metricId",
        PossibleTypes = new [] { typeof(string) })]
        string MetricId { get;  }
        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private endpoint connections.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Provisioning state of the Namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Namespace.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This determines if traffic is allowed over public network. By default it is enabled.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Endpoint you can use to perform Service Bus operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint you can use to perform Service Bus operations.",
        SerializedName = @"serviceBusEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceBusEndpoint { get;  }
        /// <summary>Status of the Namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the Namespace.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>The time the namespace was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time the namespace was updated.",
        SerializedName = @"updatedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdatedAt { get;  }

    }
    /// Properties of the namespace.
    internal partial interface IRelayNamespacePropertiesInternal

    {
        /// <summary>The time the namespace was created.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>Identifier for Azure Insights metrics.</summary>
        string MetricId { get; set; }
        /// <summary>List of private endpoint connections.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Provisioning state of the Namespace.</summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Endpoint you can use to perform Service Bus operations.</summary>
        string ServiceBusEndpoint { get; set; }
        /// <summary>Status of the Namespace.</summary>
        string Status { get; set; }
        /// <summary>The time the namespace was updated.</summary>
        global::System.DateTime? UpdatedAt { get; set; }

    }
}