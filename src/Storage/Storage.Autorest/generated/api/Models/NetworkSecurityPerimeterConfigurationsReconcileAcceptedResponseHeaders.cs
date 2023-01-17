// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    public partial class NetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.INetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.INetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.INetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>
        /// Creates an new <see cref="NetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeaders" /> instance.
        /// </summary>
        public NetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeaders()
        {

        }
    }
    public partial interface INetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface INetworkSecurityPerimeterConfigurationsReconcileAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}