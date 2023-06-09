// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.PowerShell;

    /// <summary>Properties for a Connection Setting Item</summary>
    [System.ComponentModel.TypeConverter(typeof(ConnectionSettingPropertiesTypeConverter))]
    public partial class ConnectionSettingProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConnectionSettingProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("SettingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).SettingId = (string) content.GetValueForProperty("SettingId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).SettingId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderId = (string) content.GetValueForProperty("ServiceProviderId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceProviderDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderDisplayName = (string) content.GetValueForProperty("ServiceProviderDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter[]) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Parameter, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter>(__y, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingParameterTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConnectionSettingProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("SettingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).SettingId = (string) content.GetValueForProperty("SettingId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).SettingId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderId = (string) content.GetValueForProperty("ServiceProviderId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceProviderDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderDisplayName = (string) content.GetValueForProperty("ServiceProviderDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ServiceProviderDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter[]) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).Parameter, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter>(__y, Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingParameterTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConnectionSettingProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConnectionSettingProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConnectionSettingProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ConnectionSettingProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties for a Connection Setting Item
    [System.ComponentModel.TypeConverter(typeof(ConnectionSettingPropertiesTypeConverter))]
    public partial interface IConnectionSettingProperties

    {

    }
}