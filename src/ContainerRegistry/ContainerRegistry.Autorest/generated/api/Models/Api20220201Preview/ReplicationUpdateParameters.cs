// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The parameters for updating a replication.</summary>
    public partial class ReplicationUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ReplicationUpdateParametersProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersProperties _property;

        /// <summary>The parameters for updating a replication's properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ReplicationUpdateParametersProperties()); set => this._property = value; }

        /// <summary>
        /// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional
        /// endpoint is disabled, however its data will continue to be synced with other replications.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public bool? RegionEndpointEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersPropertiesInternal)Property).RegionEndpointEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersPropertiesInternal)Property).RegionEndpointEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersTags _tag;

        /// <summary>The tags for the replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ReplicationUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ReplicationUpdateParameters" /> instance.</summary>
        public ReplicationUpdateParameters()
        {

        }
    }
    /// The parameters for updating a replication.
    public partial interface IReplicationUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional
        /// endpoint is disabled, however its data will continue to be synced with other replications.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.",
        SerializedName = @"regionEndpointEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RegionEndpointEnabled { get; set; }
        /// <summary>The tags for the replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the replication.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for updating a replication.
    internal partial interface IReplicationUpdateParametersInternal

    {
        /// <summary>The parameters for updating a replication's properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersProperties Property { get; set; }
        /// <summary>
        /// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional
        /// endpoint is disabled, however its data will continue to be synced with other replications.
        /// </summary>
        bool? RegionEndpointEnabled { get; set; }
        /// <summary>The tags for the replication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IReplicationUpdateParametersTags Tag { get; set; }

    }
}