// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    /// <summary>The response properties returned for a pipeline run.</summary>
    [System.ComponentModel.TypeConverter(typeof(PipelineRunResponseTypeConverter))]
    public partial class PipelineRunResponse
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineRunResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PipelineRunResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineRunResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PipelineRunResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PipelineRunResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PipelineRunResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineRunResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PipelineRunResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Progress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Progress = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IProgressProperties) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Progress, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ProgressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportPipelineSourceProperties) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportPipelineSourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IExportPipelineTargetProperties) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ExportPipelineTargetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Trigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Trigger = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineTriggerDescriptor) content.GetValueForProperty("Trigger",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Trigger, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineTriggerDescriptorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ImportedArtifact"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ImportedArtifact = (string[]) content.GetValueForProperty("ImportedArtifact",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ImportedArtifact, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).FinishTime = (global::System.DateTime?) content.GetValueForProperty("FinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).FinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CatalogDigest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).CatalogDigest = (string) content.GetValueForProperty("CatalogDigest",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).CatalogDigest, global::System.Convert.ToString);
            }
            if (content.Contains("PipelineRunErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).PipelineRunErrorMessage = (string) content.GetValueForProperty("PipelineRunErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).PipelineRunErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ProgressPercentage = (string) content.GetValueForProperty("ProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ProgressPercentage, global::System.Convert.ToString);
            }
            if (content.Contains("SourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineSourceType.CreateFrom);
            }
            if (content.Contains("SourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceUri = (string) content.GetValueForProperty("SourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("SourceKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceKeyVaultUri = (string) content.GetValueForProperty("SourceKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("TargetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetType = (string) content.GetValueForProperty("TargetType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetType, global::System.Convert.ToString);
            }
            if (content.Contains("TargetUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetUri = (string) content.GetValueForProperty("TargetUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetUri, global::System.Convert.ToString);
            }
            if (content.Contains("TargetKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetKeyVaultUri = (string) content.GetValueForProperty("TargetKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("TriggerSourceTrigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TriggerSourceTrigger = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineSourceTriggerDescriptor) content.GetValueForProperty("TriggerSourceTrigger",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TriggerSourceTrigger, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineSourceTriggerDescriptorTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceTriggerTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceTriggerTimestamp = (global::System.DateTime?) content.GetValueForProperty("SourceTriggerTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceTriggerTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineRunResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PipelineRunResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Progress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Progress = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IProgressProperties) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Progress, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ProgressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportPipelineSourceProperties) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportPipelineSourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IExportPipelineTargetProperties) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ExportPipelineTargetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Trigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Trigger = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineTriggerDescriptor) content.GetValueForProperty("Trigger",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Trigger, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineTriggerDescriptorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ImportedArtifact"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ImportedArtifact = (string[]) content.GetValueForProperty("ImportedArtifact",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ImportedArtifact, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FinishTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).FinishTime = (global::System.DateTime?) content.GetValueForProperty("FinishTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).FinishTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CatalogDigest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).CatalogDigest = (string) content.GetValueForProperty("CatalogDigest",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).CatalogDigest, global::System.Convert.ToString);
            }
            if (content.Contains("PipelineRunErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).PipelineRunErrorMessage = (string) content.GetValueForProperty("PipelineRunErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).PipelineRunErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ProgressPercentage = (string) content.GetValueForProperty("ProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).ProgressPercentage, global::System.Convert.ToString);
            }
            if (content.Contains("SourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineSourceType.CreateFrom);
            }
            if (content.Contains("SourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceUri = (string) content.GetValueForProperty("SourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("SourceKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceKeyVaultUri = (string) content.GetValueForProperty("SourceKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("TargetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetType = (string) content.GetValueForProperty("TargetType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetType, global::System.Convert.ToString);
            }
            if (content.Contains("TargetUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetUri = (string) content.GetValueForProperty("TargetUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetUri, global::System.Convert.ToString);
            }
            if (content.Contains("TargetKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetKeyVaultUri = (string) content.GetValueForProperty("TargetKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TargetKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("TriggerSourceTrigger"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TriggerSourceTrigger = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineSourceTriggerDescriptor) content.GetValueForProperty("TriggerSourceTrigger",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).TriggerSourceTrigger, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineSourceTriggerDescriptorTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceTriggerTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceTriggerTimestamp = (global::System.DateTime?) content.GetValueForProperty("SourceTriggerTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponseInternal)this).SourceTriggerTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The response properties returned for a pipeline run.
    [System.ComponentModel.TypeConverter(typeof(PipelineRunResponseTypeConverter))]
    public partial interface IPipelineRunResponse

    {

    }
}