// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ImportImageParametersTypeConverter))]
    public partial class ImportImageParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportImageParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ImportImageParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportImageParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ImportImageParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ImportImageParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ImportImageParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportImageParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ImportImageParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportSourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).TargetTag = (string[]) content.GetValueForProperty("TargetTag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).TargetTag, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("UntaggedTargetRepository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).UntaggedTargetRepository = (string[]) content.GetValueForProperty("UntaggedTargetRepository",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).UntaggedTargetRepository, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Mode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Mode = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ImportMode?) content.GetValueForProperty("Mode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Mode, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ImportMode.CreateFrom);
            }
            if (content.Contains("SourceCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceCredentials = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportSourceCredentials) content.GetValueForProperty("SourceCredentials",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceCredentials, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportSourceCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRegistryUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceRegistryUri = (string) content.GetValueForProperty("SourceRegistryUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceRegistryUri, global::System.Convert.ToString);
            }
            if (content.Contains("SourceImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceImage = (string) content.GetValueForProperty("SourceImage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceImage, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsUsername = (string) content.GetValueForProperty("CredentialsUsername",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsUsername, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsPassword, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportImageParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ImportImageParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportSourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).TargetTag = (string[]) content.GetValueForProperty("TargetTag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).TargetTag, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("UntaggedTargetRepository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).UntaggedTargetRepository = (string[]) content.GetValueForProperty("UntaggedTargetRepository",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).UntaggedTargetRepository, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Mode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Mode = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ImportMode?) content.GetValueForProperty("Mode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).Mode, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ImportMode.CreateFrom);
            }
            if (content.Contains("SourceCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceCredentials = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportSourceCredentials) content.GetValueForProperty("SourceCredentials",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceCredentials, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportSourceCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRegistryUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceRegistryUri = (string) content.GetValueForProperty("SourceRegistryUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceRegistryUri, global::System.Convert.ToString);
            }
            if (content.Contains("SourceImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceImage = (string) content.GetValueForProperty("SourceImage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).SourceImage, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsUsername = (string) content.GetValueForProperty("CredentialsUsername",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsUsername, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IImportImageParametersInternal)this).CredentialsPassword, global::System.Convert.ToString);
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
    [System.ComponentModel.TypeConverter(typeof(ImportImageParametersTypeConverter))]
    public partial interface IImportImageParameters

    {

    }
}