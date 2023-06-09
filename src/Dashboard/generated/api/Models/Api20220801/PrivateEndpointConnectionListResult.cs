// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// List of private endpoint connection associated with the specified storage account
    /// </summary>
    public partial class PrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnectionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnectionListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnectionListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnection[] _value;

        /// <summary>Array of private endpoint connections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnection[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionListResult" /> instance.</summary>
        public PrivateEndpointConnectionListResult()
        {

        }
    }
    /// List of private endpoint connection associated with the specified storage account
    public partial interface IPrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of operation list results (if there are any).",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of private endpoint connections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of private endpoint connections",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnection[] Value { get; set; }

    }
    /// List of private endpoint connection associated with the specified storage account
    internal partial interface IPrivateEndpointConnectionListResultInternal

    {
        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        string NextLink { get; set; }
        /// <summary>Array of private endpoint connections</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Api20220801.IPrivateEndpointConnection[] Value { get; set; }

    }
}