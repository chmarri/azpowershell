// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    /// <summary>An error response from the Azure Container Registry service.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseTypeConverter))]
    public partial class ErrorResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ErrorResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ErrorResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ErrorResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseBody) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponseBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IInnerErrorDescription[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IInnerErrorDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.InnerErrorDescriptionTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ErrorResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseBody) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ErrorResponseBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IInnerErrorDescription[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IInnerErrorDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.InnerErrorDescriptionTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ErrorResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ErrorResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IErrorResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// An error response from the Azure Container Registry service.
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseTypeConverter))]
    public partial interface IErrorResponse

    {

    }
}