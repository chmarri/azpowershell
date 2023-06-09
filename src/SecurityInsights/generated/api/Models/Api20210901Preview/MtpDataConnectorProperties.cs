// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>MTP (Microsoft Threat Protection) data connector properties.</summary>
    public partial class MtpDataConnectorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantId"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantId __dataConnectorTenantId = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorTenantId();

        /// <summary>Backing field for <see cref="DataType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypes _dataType;

        /// <summary>The available data types for the connector.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypes DataType { get => (this._dataType = this._dataType ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MtpDataConnectorDataTypes()); set => this._dataType = value; }

        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal)DataType).IncidentState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal)DataType).IncidentState = value ; }

        /// <summary>Internal Acessors for DataType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypes Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorPropertiesInternal.DataType { get => (this._dataType = this._dataType ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MtpDataConnectorDataTypes()); set { {_dataType = value;} } }

        /// <summary>Internal Acessors for DataTypeIncident</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorPropertiesInternal.DataTypeIncident { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal)DataType).Incident; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal)DataType).Incident = value; }

        /// <summary>The tenant id to connect to, and get the data from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantIdInternal)__dataConnectorTenantId).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantIdInternal)__dataConnectorTenantId).TenantId = value ; }

        /// <summary>Creates an new <see cref="MtpDataConnectorProperties" /> instance.</summary>
        public MtpDataConnectorProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dataConnectorTenantId), __dataConnectorTenantId);
            await eventListener.AssertObjectIsValid(nameof(__dataConnectorTenantId), __dataConnectorTenantId);
        }
    }
    /// MTP (Microsoft Threat Protection) data connector properties.
    public partial interface IMtpDataConnectorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantId
    {
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Describe whether this data type connection is enabled or not.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get; set; }

    }
    /// MTP (Microsoft Threat Protection) data connector properties.
    internal partial interface IMtpDataConnectorPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorTenantIdInternal
    {
        /// <summary>The available data types for the connector.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypes DataType { get; set; }
        /// <summary>Data type for Microsoft Threat Protection Platforms data connector.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon DataTypeIncident { get; set; }
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get; set; }

    }
}