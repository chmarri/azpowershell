// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Describes threat granular marking model entity</summary>
    [System.ComponentModel.TypeConverter(typeof(ThreatIntelligenceGranularMarkingModelTypeConverter))]
    public partial class ThreatIntelligenceGranularMarkingModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ThreatIntelligenceGranularMarkingModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ThreatIntelligenceGranularMarkingModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ThreatIntelligenceGranularMarkingModel" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ThreatIntelligenceGranularMarkingModel" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ThreatIntelligenceGranularMarkingModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Language"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Language = (string) content.GetValueForProperty("Language",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Language, global::System.Convert.ToString);
            }
            if (content.Contains("MarkingRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).MarkingRef = (int?) content.GetValueForProperty("MarkingRef",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).MarkingRef, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Selector"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Selector = (string[]) content.GetValueForProperty("Selector",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Selector, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ThreatIntelligenceGranularMarkingModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ThreatIntelligenceGranularMarkingModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Language"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Language = (string) content.GetValueForProperty("Language",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Language, global::System.Convert.ToString);
            }
            if (content.Contains("MarkingRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).MarkingRef = (int?) content.GetValueForProperty("MarkingRef",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).MarkingRef, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Selector"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Selector = (string[]) content.GetValueForProperty("Selector",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal)this).Selector, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes threat granular marking model entity
    [System.ComponentModel.TypeConverter(typeof(ThreatIntelligenceGranularMarkingModelTypeConverter))]
    public partial interface IThreatIntelligenceGranularMarkingModel

    {

    }
}