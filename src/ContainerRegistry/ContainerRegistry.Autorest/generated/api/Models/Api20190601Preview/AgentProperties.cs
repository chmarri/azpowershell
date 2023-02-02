// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties that determine the run agent configuration.</summary>
    public partial class AgentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Cpu" /> property.</summary>
        private int? _cpu;

        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public int? Cpu { get => this._cpu; set => this._cpu = value; }

        /// <summary>Creates an new <see cref="AgentProperties" /> instance.</summary>
        public AgentProperties()
        {

        }
    }
    /// The properties that determine the run agent configuration.
    public partial interface IAgentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CPU configuration in terms of number of cores required for the run.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? Cpu { get; set; }

    }
    /// The properties that determine the run agent configuration.
    internal partial interface IAgentPropertiesInternal

    {
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        int? Cpu { get; set; }

    }
}