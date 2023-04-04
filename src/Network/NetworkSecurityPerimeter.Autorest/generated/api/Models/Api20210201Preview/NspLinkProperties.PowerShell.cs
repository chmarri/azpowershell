// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.PowerShell;

    /// <summary>Properties of NSP Link resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(NspLinkPropertiesTypeConverter))]
    public partial class NspLinkProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NspLinkProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NspLinkProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NspLinkProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NspLinkProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NspLinkProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkProvisioningState.CreateFrom);
            }
            if (content.Contains("AutoApprovedRemotePerimeterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).AutoApprovedRemotePerimeterResourceId = (string) content.GetValueForProperty("AutoApprovedRemotePerimeterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).AutoApprovedRemotePerimeterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RemotePerimeterGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterGuid = (string) content.GetValueForProperty("RemotePerimeterGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterGuid, global::System.Convert.ToString);
            }
            if (content.Contains("RemotePerimeterLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterLocation = (string) content.GetValueForProperty("RemotePerimeterLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterLocation, global::System.Convert.ToString);
            }
            if (content.Contains("LocalInboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalInboundProfile = (string[]) content.GetValueForProperty("LocalInboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalInboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocalOutboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalOutboundProfile = (string[]) content.GetValueForProperty("LocalOutboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalOutboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RemoteInboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteInboundProfile = (string[]) content.GetValueForProperty("RemoteInboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteInboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RemoteOutboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteOutboundProfile = (string[]) content.GetValueForProperty("RemoteOutboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteOutboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NspLinkProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkProvisioningState.CreateFrom);
            }
            if (content.Contains("AutoApprovedRemotePerimeterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).AutoApprovedRemotePerimeterResourceId = (string) content.GetValueForProperty("AutoApprovedRemotePerimeterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).AutoApprovedRemotePerimeterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RemotePerimeterGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterGuid = (string) content.GetValueForProperty("RemotePerimeterGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterGuid, global::System.Convert.ToString);
            }
            if (content.Contains("RemotePerimeterLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterLocation = (string) content.GetValueForProperty("RemotePerimeterLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemotePerimeterLocation, global::System.Convert.ToString);
            }
            if (content.Contains("LocalInboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalInboundProfile = (string[]) content.GetValueForProperty("LocalInboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalInboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocalOutboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalOutboundProfile = (string[]) content.GetValueForProperty("LocalOutboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).LocalOutboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RemoteInboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteInboundProfile = (string[]) content.GetValueForProperty("RemoteInboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteInboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RemoteOutboundProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteOutboundProfile = (string[]) content.GetValueForProperty("RemoteOutboundProfile",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).RemoteOutboundProfile, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of NSP Link resource.
    [System.ComponentModel.TypeConverter(typeof(NspLinkPropertiesTypeConverter))]
    public partial interface INspLinkProperties

    {

    }
}