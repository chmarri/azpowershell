// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    /// <summary>The properties for updating base image dependency trigger.</summary>
    [System.ComponentModel.TypeConverter(typeof(BaseImageTriggerUpdateParametersTypeConverter))]
    public partial class BaseImageTriggerUpdateParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BaseImageTriggerUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("BaseImageTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).BaseImageTriggerType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType?) content.GetValueForProperty("BaseImageTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).BaseImageTriggerType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType.CreateFrom);
            }
            if (content.Contains("UpdateTriggerEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerEndpoint = (string) content.GetValueForProperty("UpdateTriggerEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateTriggerPayloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerPayloadType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType?) content.GetValueForProperty("UpdateTriggerPayloadType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerPayloadType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType.CreateFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Name, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BaseImageTriggerUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("BaseImageTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).BaseImageTriggerType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType?) content.GetValueForProperty("BaseImageTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).BaseImageTriggerType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType.CreateFrom);
            }
            if (content.Contains("UpdateTriggerEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerEndpoint = (string) content.GetValueForProperty("UpdateTriggerEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateTriggerPayloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerPayloadType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType?) content.GetValueForProperty("UpdateTriggerPayloadType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).UpdateTriggerPayloadType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType.CreateFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)this).Name, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BaseImageTriggerUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BaseImageTriggerUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BaseImageTriggerUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BaseImageTriggerUpdateParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The properties for updating base image dependency trigger.
    [System.ComponentModel.TypeConverter(typeof(BaseImageTriggerUpdateParametersTypeConverter))]
    public partial interface IBaseImageTriggerUpdateParameters

    {

    }
}