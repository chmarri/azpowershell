// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.PowerShell;

    /// <summary>A partial update to the RedisEnterprise cluster</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterUpdateTypeConverter))]
    public partial class ClusterUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.SkuName.CreateFrom);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ResourceState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ResourceState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState?) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ResourceState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState.CreateFrom);
            }
            if (content.Contains("MinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).MinimumTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.TlsVersion?) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).MinimumTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.TlsVersion.CreateFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("RedisVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).RedisVersion = (string) content.GetValueForProperty("RedisVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).RedisVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.SkuName.CreateFrom);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ResourceState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ResourceState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState?) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).ResourceState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState.CreateFrom);
            }
            if (content.Contains("MinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).MinimumTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.TlsVersion?) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).MinimumTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.TlsVersion.CreateFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("RedisVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).RedisVersion = (string) content.GetValueForProperty("RedisVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).RedisVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdateInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.ClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ClusterUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api202201.IClusterUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A partial update to the RedisEnterprise cluster
    [System.ComponentModel.TypeConverter(typeof(ClusterUpdateTypeConverter))]
    public partial interface IClusterUpdate

    {

    }
}