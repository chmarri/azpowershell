// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>Export operation configuration information</summary>
    public partial class ServiceExportConfigurationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceExportConfigurationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceExportConfigurationInfoInternal
    {

        /// <summary>Backing field for <see cref="StorageAccountName" /> property.</summary>
        private string _storageAccountName;

        /// <summary>The name of the default export storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public string StorageAccountName { get => this._storageAccountName; set => this._storageAccountName = value; }

        /// <summary>Creates an new <see cref="ServiceExportConfigurationInfo" /> instance.</summary>
        public ServiceExportConfigurationInfo()
        {

        }
    }
    /// Export operation configuration information
    public partial interface IServiceExportConfigurationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>The name of the default export storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the default export storage account.",
        SerializedName = @"storageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }

    }
    /// Export operation configuration information
    internal partial interface IServiceExportConfigurationInfoInternal

    {
        /// <summary>The name of the default export storage account.</summary>
        string StorageAccountName { get; set; }

    }
}