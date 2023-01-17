// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901
{
    using Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.PowerShell;

    /// <summary>Information of Access Rule in Network Security Perimeter profile</summary>
    [System.ComponentModel.TypeConverter(typeof(NspAccessRuleTypeConverter))]
    public partial class NspAccessRule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NspAccessRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NspAccessRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NspAccessRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NspAccessRule" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NspAccessRule(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Support.NspAccessRuleDirection?) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.Storage.Support.NspAccessRuleDirection.CreateFrom);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).AddressPrefix = (string[]) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).AddressPrefix, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Subscription = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRulePropertiesSubscriptionsItem[]) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Subscription, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRulePropertiesSubscriptionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRulePropertiesSubscriptionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).NetworkSecurityPerimeter = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INetworkSecurityPerimeter[]) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).NetworkSecurityPerimeter, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INetworkSecurityPerimeter>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NetworkSecurityPerimeterTypeConverter.ConvertFrom));
            }
            if (content.Contains("FullyQualifiedDomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).FullyQualifiedDomainName = (string[]) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).FullyQualifiedDomainName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NspAccessRule(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Support.NspAccessRuleDirection?) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.Storage.Support.NspAccessRuleDirection.CreateFrom);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).AddressPrefix = (string[]) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).AddressPrefix, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Subscription = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRulePropertiesSubscriptionsItem[]) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).Subscription, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRulePropertiesSubscriptionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NspAccessRulePropertiesSubscriptionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).NetworkSecurityPerimeter = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INetworkSecurityPerimeter[]) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).NetworkSecurityPerimeter, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INetworkSecurityPerimeter>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.NetworkSecurityPerimeterTypeConverter.ConvertFrom));
            }
            if (content.Contains("FullyQualifiedDomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).FullyQualifiedDomainName = (string[]) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20220901.INspAccessRuleInternal)this).FullyQualifiedDomainName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Information of Access Rule in Network Security Perimeter profile
    [System.ComponentModel.TypeConverter(typeof(NspAccessRuleTypeConverter))]
    public partial interface INspAccessRule

    {

    }
}