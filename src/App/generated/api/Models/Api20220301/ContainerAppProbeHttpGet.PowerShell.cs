// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [System.ComponentModel.TypeConverter(typeof(ContainerAppProbeHttpGetTypeConverter))]
    public partial class ContainerAppProbeHttpGet
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ContainerAppProbeHttpGet(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Host"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Host = (string) content.GetValueForProperty("Host",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Host, global::System.Convert.ToString);
            }
            if (content.Contains("HttpHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).HttpHeader = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetHttpHeadersItem[]) content.GetValueForProperty("HttpHeader",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).HttpHeader, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetHttpHeadersItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGetHttpHeadersItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Path"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Path = (string) content.GetValueForProperty("Path",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Path, global::System.Convert.ToString);
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Port = (int) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Scheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Scheme = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.Scheme?) content.GetValueForProperty("Scheme",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Scheme, Microsoft.Azure.PowerShell.Cmdlets.App.Support.Scheme.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ContainerAppProbeHttpGet(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Host"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Host = (string) content.GetValueForProperty("Host",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Host, global::System.Convert.ToString);
            }
            if (content.Contains("HttpHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).HttpHeader = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetHttpHeadersItem[]) content.GetValueForProperty("HttpHeader",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).HttpHeader, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetHttpHeadersItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGetHttpHeadersItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Path"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Path = (string) content.GetValueForProperty("Path",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Path, global::System.Convert.ToString);
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Port = (int) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Scheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Scheme = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.Scheme?) content.GetValueForProperty("Scheme",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGetInternal)this).Scheme, Microsoft.Azure.PowerShell.Cmdlets.App.Support.Scheme.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGet DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ContainerAppProbeHttpGet(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ContainerAppProbeHttpGet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGet DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ContainerAppProbeHttpGet(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContainerAppProbeHttpGet" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ContainerAppProbeHttpGet" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeHttpGet FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// HTTPGet specifies the http request to perform.
    [System.ComponentModel.TypeConverter(typeof(ContainerAppProbeHttpGetTypeConverter))]
    public partial interface IContainerAppProbeHttpGet

    {

    }
}