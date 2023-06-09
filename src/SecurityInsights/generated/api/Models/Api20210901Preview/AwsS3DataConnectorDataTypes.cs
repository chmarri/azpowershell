// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>The available data types for Amazon Web Services S3 data connector.</summary>
    public partial class AwsS3DataConnectorDataTypes :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorDataTypes,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorDataTypesInternal
    {

        /// <summary>Backing field for <see cref="Log" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon _log;

        /// <summary>Logs data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Log { get => (this._log = this._log ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommon()); set => this._log = value; }

        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState LogState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommonInternal)Log).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommonInternal)Log).State = value ; }

        /// <summary>Internal Acessors for Log</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorDataTypesInternal.Log { get => (this._log = this._log ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommon()); set { {_log = value;} } }

        /// <summary>Creates an new <see cref="AwsS3DataConnectorDataTypes" /> instance.</summary>
        public AwsS3DataConnectorDataTypes()
        {

        }
    }
    /// The available data types for Amazon Web Services S3 data connector.
    public partial interface IAwsS3DataConnectorDataTypes :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Describe whether this data type connection is enabled or not.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState LogState { get; set; }

    }
    /// The available data types for Amazon Web Services S3 data connector.
    internal partial interface IAwsS3DataConnectorDataTypesInternal

    {
        /// <summary>Logs data type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Log { get; set; }
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState LogState { get; set; }

    }
}