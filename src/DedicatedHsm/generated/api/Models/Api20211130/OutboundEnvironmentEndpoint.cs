// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Extensions;

    /// <summary>Egress endpoints which dedicated hsm service connects to for common purpose.</summary>
    public partial class OutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IOutboundEnvironmentEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IOutboundEnvironmentEndpointInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IEndpointDependency[] _endpoint;

        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IEndpointDependency[] Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpoint" /> instance.</summary>
        public OutboundEnvironmentEndpoint()
        {

        }
    }
    /// Egress endpoints which dedicated hsm service connects to for common purpose.
    public partial interface IOutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoints that dedicated hsm service connects to",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IEndpointDependency) })]
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IEndpointDependency[] Endpoint { get; set; }

    }
    /// Egress endpoints which dedicated hsm service connects to for common purpose.
    internal partial interface IOutboundEnvironmentEndpointInternal

    {
        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        string Category { get; set; }
        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IEndpointDependency[] Endpoint { get; set; }

    }
}