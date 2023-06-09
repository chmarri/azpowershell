// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Container App Dapr configuration.</summary>
    public partial class Dapr :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDapr,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDaprInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>Dapr application identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; set => this._appId = value; }

        /// <summary>Backing field for <see cref="AppPort" /> property.</summary>
        private int? _appPort;

        /// <summary>Tells Dapr which port your application is listening on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public int? AppPort { get => this._appPort; set => this._appPort = value; }

        /// <summary>Backing field for <see cref="AppProtocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? _appProtocol;

        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? AppProtocol { get => this._appProtocol; set => this._appProtocol = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="Dapr" /> instance.</summary>
        public Dapr()
        {

        }
    }
    /// Container App Dapr configuration.
    public partial interface IDapr :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Dapr application identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dapr application identifier",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>Tells Dapr which port your application is listening on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells Dapr which port your application is listening on",
        SerializedName = @"appPort",
        PossibleTypes = new [] { typeof(int) })]
        int? AppPort { get; set; }
        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http",
        SerializedName = @"appProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? AppProtocol { get; set; }
        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean indicating if the Dapr side car is enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// Container App Dapr configuration.
    internal partial interface IDaprInternal

    {
        /// <summary>Dapr application identifier</summary>
        string AppId { get; set; }
        /// <summary>Tells Dapr which port your application is listening on</summary>
        int? AppPort { get; set; }
        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? AppProtocol { get; set; }
        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        bool? Enabled { get; set; }

    }
}