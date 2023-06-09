// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.PowerShell;

    /// <summary>The definition of data present in the report.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReportConfigDatasetTypeConverter))]
    public partial class ReportConfigDataset
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDataset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReportConfigDataset(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDataset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReportConfigDataset(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReportConfigDataset" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReportConfigDataset" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDataset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReportConfigDataset(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Granularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Granularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType?) content.GetValueForProperty("Granularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Granularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType.CreateFrom);
            }
            if (content.Contains("Aggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Aggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetAggregation) content.GetValueForProperty("Aggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Aggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Grouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Grouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping[]) content.GetValueForProperty("Grouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Grouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("Sorting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Sorting = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting[]) content.GetValueForProperty("Sorting",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Sorting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigSortingTypeConverter.ConvertFrom));
            }
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDataset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReportConfigDataset(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Granularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Granularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType?) content.GetValueForProperty("Granularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Granularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType.CreateFrom);
            }
            if (content.Contains("Aggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Aggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetAggregation) content.GetValueForProperty("Aggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Aggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Grouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Grouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping[]) content.GetValueForProperty("Grouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Grouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("Sorting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Sorting = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting[]) content.GetValueForProperty("Sorting",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Sorting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigSortingTypeConverter.ConvertFrom));
            }
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The definition of data present in the report.
    [System.ComponentModel.TypeConverter(typeof(ReportConfigDatasetTypeConverter))]
    public partial interface IReportConfigDataset

    {

    }
}