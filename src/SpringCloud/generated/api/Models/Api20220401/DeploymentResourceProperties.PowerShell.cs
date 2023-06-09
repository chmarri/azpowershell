// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Deployment resource properties payload</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourcePropertiesTypeConverter))]
    public partial class DeploymentResourceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeploymentSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.UserSourceInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceProvisioningState.CreateFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus.CreateFrom);
            }
            if (content.Contains("Active"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Instance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentInstanceTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeploymentSettingResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceRequests) content.GetValueForProperty("DeploymentSettingResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeploymentSettingEnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeploymentSettingAddonConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingAddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettingsAddonConfigs) content.GetValueForProperty("DeploymentSettingAddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingAddonConfig, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsAddonConfigsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeploymentSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.UserSourceInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceProvisioningState.CreateFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus.CreateFrom);
            }
            if (content.Contains("Active"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Instance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentInstanceTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeploymentSettingResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceRequests) content.GetValueForProperty("DeploymentSettingResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeploymentSettingEnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeploymentSettingAddonConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingAddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentSettingsAddonConfigs) content.GetValueForProperty("DeploymentSettingAddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).DeploymentSettingAddonConfig, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentSettingsAddonConfigsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeploymentResourceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IDeploymentResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Deployment resource properties payload
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourcePropertiesTypeConverter))]
    public partial interface IDeploymentResourceProperties

    {

    }
}