// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The request that generated the event.</summary>
    public partial class Request :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IRequestInternal
    {

        /// <summary>Backing field for <see cref="Addr" /> property.</summary>
        private string _addr;

        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Addr { get => this._addr; set => this._addr = value; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the request that initiated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Method" /> property.</summary>
        private string _method;

        /// <summary>The request method that generated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Method { get => this._method; set => this._method = value; }

        /// <summary>Backing field for <see cref="Useragent" /> property.</summary>
        private string _useragent;

        /// <summary>The user agent header of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Useragent { get => this._useragent; set => this._useragent = value; }

        /// <summary>Creates an new <see cref="Request" /> instance.</summary>
        public Request()
        {

        }
    }
    /// The request that generated the event.
    public partial interface IRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the standard http request.",
        SerializedName = @"addr",
        PossibleTypes = new [] { typeof(string) })]
        string Addr { get; set; }
        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>The ID of the request that initiated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the request that initiated the event.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The request method that generated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request method that generated the event.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        string Method { get; set; }
        /// <summary>The user agent header of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user agent header of the request.",
        SerializedName = @"useragent",
        PossibleTypes = new [] { typeof(string) })]
        string Useragent { get; set; }

    }
    /// The request that generated the event.
    internal partial interface IRequestInternal

    {
        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        string Addr { get; set; }
        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        string Host { get; set; }
        /// <summary>The ID of the request that initiated the event.</summary>
        string Id { get; set; }
        /// <summary>The request method that generated the event.</summary>
        string Method { get; set; }
        /// <summary>The user agent header of the request.</summary>
        string Useragent { get; set; }

    }
}