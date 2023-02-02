// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The parameters for updating an agent pool.</summary>
    public partial class AgentPoolUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersInternal
    {

        /// <summary>The count of agent machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public int? Count { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParametersInternal)Property).Count; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParametersInternal)Property).Count = value ?? default(int); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentPoolPropertiesUpdateParameters()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParameters _property;

        /// <summary>The properties associated with the agent pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentPoolPropertiesUpdateParameters()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersTags _tag;

        /// <summary>The ARM resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentPoolUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="AgentPoolUpdateParameters" /> instance.</summary>
        public AgentPoolUpdateParameters()
        {

        }
    }
    /// The parameters for updating an agent pool.
    public partial interface IAgentPoolUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The count of agent machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The count of agent machine",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? Count { get; set; }
        /// <summary>The ARM resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ARM resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for updating an agent pool.
    internal partial interface IAgentPoolUpdateParametersInternal

    {
        /// <summary>The count of agent machine</summary>
        int? Count { get; set; }
        /// <summary>The properties associated with the agent pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolPropertiesUpdateParameters Property { get; set; }
        /// <summary>The ARM resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolUpdateParametersTags Tag { get; set; }

    }
}