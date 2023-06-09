// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxDeploymentUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeploymentUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeploymentUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="EnableDiagnosticsSupport" /> property.</summary>
        private bool? _enableDiagnosticsSupport;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public bool? EnableDiagnosticsSupport { get => this._enableDiagnosticsSupport; set => this._enableDiagnosticsSupport = value; }

        /// <summary>Backing field for <see cref="Logging" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLogging _logging;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLogging Logging { get => (this._logging = this._logging ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.NginxLogging()); set => this._logging = value; }

        /// <summary>Internal Acessors for Logging</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLogging Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeploymentUpdatePropertiesInternal.Logging { get => (this._logging = this._logging ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.NginxLogging()); set { {_logging = value;} } }

        /// <summary>Internal Acessors for LoggingStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxStorageAccount Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeploymentUpdatePropertiesInternal.LoggingStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccount = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccountContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccountContainerName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLoggingInternal)Logging).StorageAccountName = value ?? null; }

        /// <summary>Creates an new <see cref="NginxDeploymentUpdateProperties" /> instance.</summary>
        public NginxDeploymentUpdateProperties()
        {

        }
    }
    public partial interface INginxDeploymentUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDiagnosticsSupport",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDiagnosticsSupport { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountContainerName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }

    }
    internal partial interface INginxDeploymentUpdatePropertiesInternal

    {
        bool? EnableDiagnosticsSupport { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxLogging Logging { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxStorageAccount LoggingStorageAccount { get; set; }

        string StorageAccountContainerName { get; set; }

        string StorageAccountName { get; set; }

    }
}