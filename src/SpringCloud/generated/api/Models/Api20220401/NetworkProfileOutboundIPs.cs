// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Desired outbound IP resources for Azure Spring Apps resource.</summary>
    public partial class NetworkProfileOutboundIPs :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileOutboundIPs,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileOutboundIPsInternal
    {

        /// <summary>Internal Acessors for PublicIP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.INetworkProfileOutboundIPsInternal.PublicIP { get => this._publicIP; set { {_publicIP = value;} } }

        /// <summary>Backing field for <see cref="PublicIP" /> property.</summary>
        private string[] _publicIP;

        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string[] PublicIP { get => this._publicIP; }

        /// <summary>Creates an new <see cref="NetworkProfileOutboundIPs" /> instance.</summary>
        public NetworkProfileOutboundIPs()
        {

        }
    }
    /// Desired outbound IP resources for Azure Spring Apps resource.
    public partial interface INetworkProfileOutboundIPs :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of public IP addresses.",
        SerializedName = @"publicIPs",
        PossibleTypes = new [] { typeof(string) })]
        string[] PublicIP { get;  }

    }
    /// Desired outbound IP resources for Azure Spring Apps resource.
    internal partial interface INetworkProfileOutboundIPsInternal

    {
        /// <summary>A list of public IP addresses.</summary>
        string[] PublicIP { get; set; }

    }
}