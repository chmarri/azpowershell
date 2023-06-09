// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.PowerShell;

    /// <summary>States and configurations of Cost Analysis.</summary>
    [System.ComponentModel.TypeConverter(typeof(ViewTypeConverter))]
    public partial class View
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.View"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IView" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IView DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new View(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.View"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IView" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IView DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new View(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="View" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="View" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IView FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.View"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal View(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ViewPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("Query"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Query = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDefinition) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Query, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DateRange = (string) content.GetValueForProperty("DateRange",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DateRange, global::System.Convert.ToString);
            }
            if (content.Contains("Currency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Currency = (string) content.GetValueForProperty("Currency",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Currency, global::System.Convert.ToString);
            }
            if (content.Contains("Chart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Chart = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ChartType?) content.GetValueForProperty("Chart",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Chart, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ChartType.CreateFrom);
            }
            if (content.Contains("Accumulated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Accumulated = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AccumulatedType?) content.GetValueForProperty("Accumulated",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Accumulated, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AccumulatedType.CreateFrom);
            }
            if (content.Contains("Metric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Metric = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.MetricType?) content.GetValueForProperty("Metric",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Metric, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.MetricType.CreateFrom);
            }
            if (content.Contains("Kpi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Kpi = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IKpiProperties[]) content.GetValueForProperty("Kpi",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Kpi, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IKpiProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.KpiPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("Pivot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Pivot = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IPivotProperties[]) content.GetValueForProperty("Pivot",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Pivot, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IPivotProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.PivotPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("QueryTimePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimePeriod = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigTimePeriod) content.GetValueForProperty("QueryTimePeriod",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimePeriod, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigTimePeriodTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryDataSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryDataSet = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset) content.GetValueForProperty("QueryDataSet",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryDataSet, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryType = (string) content.GetValueForProperty("QueryType",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryType, global::System.Convert.ToString);
            }
            if (content.Contains("QueryTimeframe"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimeframe = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportTimeframeType) content.GetValueForProperty("QueryTimeframe",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimeframe, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportTimeframeType.CreateFrom);
            }
            if (content.Contains("QueryIncludeMonetaryCommitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryIncludeMonetaryCommitment = (bool?) content.GetValueForProperty("QueryIncludeMonetaryCommitment",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryIncludeMonetaryCommitment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TimePeriodFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodFrom = (global::System.DateTime) content.GetValueForProperty("TimePeriodFrom",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimePeriodTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodTo = (global::System.DateTime) content.GetValueForProperty("TimePeriodTo",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataSetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetConfiguration) content.GetValueForProperty("DataSetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSetGranularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGranularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType?) content.GetValueForProperty("DataSetGranularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGranularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType.CreateFrom);
            }
            if (content.Contains("DataSetAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetAggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetAggregation) content.GetValueForProperty("DataSetAggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetAggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSetGrouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGrouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping[]) content.GetValueForProperty("DataSetGrouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGrouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataSetSorting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetSorting = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting[]) content.GetValueForProperty("DataSetSorting",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetSorting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigSortingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataSetFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigFilter) content.GetValueForProperty("DataSetFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.View"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal View(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ViewPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IProxyResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("Query"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Query = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDefinition) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Query, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DateRange = (string) content.GetValueForProperty("DateRange",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DateRange, global::System.Convert.ToString);
            }
            if (content.Contains("Currency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Currency = (string) content.GetValueForProperty("Currency",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Currency, global::System.Convert.ToString);
            }
            if (content.Contains("Chart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Chart = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ChartType?) content.GetValueForProperty("Chart",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Chart, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ChartType.CreateFrom);
            }
            if (content.Contains("Accumulated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Accumulated = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AccumulatedType?) content.GetValueForProperty("Accumulated",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Accumulated, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AccumulatedType.CreateFrom);
            }
            if (content.Contains("Metric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Metric = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.MetricType?) content.GetValueForProperty("Metric",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Metric, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.MetricType.CreateFrom);
            }
            if (content.Contains("Kpi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Kpi = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IKpiProperties[]) content.GetValueForProperty("Kpi",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Kpi, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IKpiProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.KpiPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("Pivot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Pivot = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IPivotProperties[]) content.GetValueForProperty("Pivot",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).Pivot, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IPivotProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.PivotPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("QueryTimePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimePeriod = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigTimePeriod) content.GetValueForProperty("QueryTimePeriod",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimePeriod, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigTimePeriodTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryDataSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryDataSet = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDataset) content.GetValueForProperty("QueryDataSet",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryDataSet, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryType = (string) content.GetValueForProperty("QueryType",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryType, global::System.Convert.ToString);
            }
            if (content.Contains("QueryTimeframe"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimeframe = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportTimeframeType) content.GetValueForProperty("QueryTimeframe",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryTimeframe, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportTimeframeType.CreateFrom);
            }
            if (content.Contains("QueryIncludeMonetaryCommitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryIncludeMonetaryCommitment = (bool?) content.GetValueForProperty("QueryIncludeMonetaryCommitment",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).QueryIncludeMonetaryCommitment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TimePeriodFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodFrom = (global::System.DateTime) content.GetValueForProperty("TimePeriodFrom",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimePeriodTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodTo = (global::System.DateTime) content.GetValueForProperty("TimePeriodTo",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).TimePeriodTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataSetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetConfiguration) content.GetValueForProperty("DataSetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSetGranularity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGranularity = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType?) content.GetValueForProperty("DataSetGranularity",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGranularity, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportGranularityType.CreateFrom);
            }
            if (content.Contains("DataSetAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetAggregation = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigDatasetAggregation) content.GetValueForProperty("DataSetAggregation",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetAggregation, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigDatasetAggregationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSetGrouping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGrouping = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping[]) content.GetValueForProperty("DataSetGrouping",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetGrouping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigGrouping>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigGroupingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataSetSorting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetSorting = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting[]) content.GetValueForProperty("DataSetSorting",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetSorting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigSorting>(__y, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigSortingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataSetFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IReportConfigFilter) content.GetValueForProperty("DataSetFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).DataSetFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ReportConfigFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ConfigurationColumn = (string[]) content.GetValueForProperty("ConfigurationColumn",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IViewInternal)this).ConfigurationColumn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// States and configurations of Cost Analysis.
    [System.ComponentModel.TypeConverter(typeof(ViewTypeConverter))]
    public partial interface IView

    {

    }
}