// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Entity insight Item.</summary>
    [System.ComponentModel.TypeConverter(typeof(EntityInsightItemTypeConverter))]
    public partial class EntityInsightItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItem"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EntityInsightItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItem"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EntityInsightItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EntityInsightItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QueryTimeInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeInterval = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemQueryTimeInterval) content.GetValueForProperty("QueryTimeInterval",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeInterval, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItemQueryTimeIntervalTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQueryResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResult = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult) content.GetValueForProperty("TableQueryResult",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResult, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryId = (string) content.GetValueForProperty("QueryId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryId, global::System.Convert.ToString);
            }
            if (content.Contains("ChartQueryResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).ChartQueryResult = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult[]) content.GetValueForProperty("ChartQueryResult",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).ChartQueryResult, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("QueryTimeIntervalStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalStartTime = (global::System.DateTime?) content.GetValueForProperty("QueryTimeIntervalStartTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("QueryTimeIntervalEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalEndTime = (global::System.DateTime?) content.GetValueForProperty("QueryTimeIntervalEndTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TableQueryResultColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultColumn = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[]) content.GetValueForProperty("TableQueryResultColumn",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultColumn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultColumnsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableQueryResultRow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultRow = (string[][]) content.GetValueForProperty("TableQueryResultRow",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultRow, __y => TypeConverterExtensions.SelectToArray<string[]>(__y, __w => TypeConverterExtensions.SelectToArray<string>(__w, global::System.Convert.ToString)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EntityInsightItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QueryTimeInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeInterval = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemQueryTimeInterval) content.GetValueForProperty("QueryTimeInterval",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeInterval, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityInsightItemQueryTimeIntervalTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQueryResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResult = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult) content.GetValueForProperty("TableQueryResult",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResult, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("QueryId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryId = (string) content.GetValueForProperty("QueryId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryId, global::System.Convert.ToString);
            }
            if (content.Contains("ChartQueryResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).ChartQueryResult = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult[]) content.GetValueForProperty("ChartQueryResult",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).ChartQueryResult, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("QueryTimeIntervalStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalStartTime = (global::System.DateTime?) content.GetValueForProperty("QueryTimeIntervalStartTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("QueryTimeIntervalEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalEndTime = (global::System.DateTime?) content.GetValueForProperty("QueryTimeIntervalEndTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).QueryTimeIntervalEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TableQueryResultColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultColumn = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[]) content.GetValueForProperty("TableQueryResultColumn",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultColumn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightsTableResultColumnsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableQueryResultRow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultRow = (string[][]) content.GetValueForProperty("TableQueryResultRow",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItemInternal)this).TableQueryResultRow, __y => TypeConverterExtensions.SelectToArray<string[]>(__y, __w => TypeConverterExtensions.SelectToArray<string>(__w, global::System.Convert.ToString)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EntityInsightItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EntityInsightItem" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInsightItem FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Entity insight Item.
    [System.ComponentModel.TypeConverter(typeof(EntityInsightItemTypeConverter))]
    public partial interface IEntityInsightItem

    {

    }
}