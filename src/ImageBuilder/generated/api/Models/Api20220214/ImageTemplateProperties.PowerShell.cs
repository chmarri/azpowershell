// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214
{
    using Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.PowerShell;

    /// <summary>Describes the properties of an image template</summary>
    [System.ComponentModel.TypeConverter(typeof(ImageTemplatePropertiesTypeConverter))]
    public partial class ImageTemplateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ImageTemplateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ImageTemplateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ImageTemplateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ImageTemplateProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ImageTemplateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Validate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Validate = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesValidate) content.GetValueForProperty("Validate",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Validate, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplatePropertiesValidateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IProvisioningError) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningError, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ProvisioningErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastRunStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatus = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateLastRunStatus) content.GetValueForProperty("LastRunStatus",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatus, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateLastRunStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfile = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateVMProfile) content.GetValueForProperty("VMProfile",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfile, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateVMProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateSourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Customize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Customize = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateCustomizer[]) content.GetValueForProperty("Customize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Customize, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateCustomizer>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateCustomizerTypeConverter.ConvertFrom));
            }
            if (content.Contains("Distribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Distribute = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateDistributor[]) content.GetValueForProperty("Distribute",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Distribute, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateDistributor>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateDistributorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("BuildTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).BuildTimeoutInMinute = (int?) content.GetValueForProperty("BuildTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).BuildTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StagingResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).StagingResourceGroup = (string) content.GetValueForProperty("StagingResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).StagingResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("ExactStagingResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ExactStagingResourceGroup = (string) content.GetValueForProperty("ExactStagingResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ExactStagingResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorMessage = (string) content.GetValueForProperty("ProvisioningErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastRunStatusRunState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState?) content.GetValueForProperty("LastRunStatusRunState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState.CreateFrom);
            }
            if (content.Contains("ValidateContinueDistributeOnFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateContinueDistributeOnFailure = (bool?) content.GetValueForProperty("ValidateContinueDistributeOnFailure",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateContinueDistributeOnFailure, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ValidateSourceValidationOnly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateSourceValidationOnly = (bool?) content.GetValueForProperty("ValidateSourceValidationOnly",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateSourceValidationOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ValidateInVMValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateInVMValidation = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateInVMValidator[]) content.GetValueForProperty("ValidateInVMValidation",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateInVMValidation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateInVMValidator>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateInVMValidatorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorCode = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode?) content.GetValueForProperty("ProvisioningErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorCode, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode.CreateFrom);
            }
            if (content.Contains("LastRunStatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusStartTime = (global::System.DateTime?) content.GetValueForProperty("LastRunStatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRunStatusEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusEndTime = (global::System.DateTime?) content.GetValueForProperty("LastRunStatusEndTime",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRunStatusRunSubState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunSubState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunSubState?) content.GetValueForProperty("LastRunStatusRunSubState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunSubState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunSubState.CreateFrom);
            }
            if (content.Contains("LastRunStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusMessage = (string) content.GetValueForProperty("LastRunStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("VMProfileVnetConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVnetConfig = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IVirtualNetworkConfig) content.GetValueForProperty("VMProfileVnetConfig",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVnetConfig, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.VirtualNetworkConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMProfileVmsize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVmsize = (string) content.GetValueForProperty("VMProfileVmsize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVmsize, global::System.Convert.ToString);
            }
            if (content.Contains("VMProfileOsdiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileOsdiskSizeGb = (int?) content.GetValueForProperty("VMProfileOsdiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileOsdiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMProfileUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileUserAssignedIdentity = (string[]) content.GetValueForProperty("VMProfileUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileUserAssignedIdentity, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VnetConfigSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigSubnetId = (string) content.GetValueForProperty("VnetConfigSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigProxyVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigProxyVMSize = (string) content.GetValueForProperty("VnetConfigProxyVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigProxyVMSize, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ImageTemplateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Validate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Validate = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesValidate) content.GetValueForProperty("Validate",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Validate, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplatePropertiesValidateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IProvisioningError) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningError, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ProvisioningErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastRunStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatus = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateLastRunStatus) content.GetValueForProperty("LastRunStatus",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatus, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateLastRunStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfile = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateVMProfile) content.GetValueForProperty("VMProfile",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfile, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateVMProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateSourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Customize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Customize = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateCustomizer[]) content.GetValueForProperty("Customize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Customize, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateCustomizer>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateCustomizerTypeConverter.ConvertFrom));
            }
            if (content.Contains("Distribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Distribute = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateDistributor[]) content.GetValueForProperty("Distribute",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).Distribute, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateDistributor>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateDistributorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("BuildTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).BuildTimeoutInMinute = (int?) content.GetValueForProperty("BuildTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).BuildTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StagingResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).StagingResourceGroup = (string) content.GetValueForProperty("StagingResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).StagingResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("ExactStagingResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ExactStagingResourceGroup = (string) content.GetValueForProperty("ExactStagingResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ExactStagingResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorMessage = (string) content.GetValueForProperty("ProvisioningErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastRunStatusRunState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState?) content.GetValueForProperty("LastRunStatusRunState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState.CreateFrom);
            }
            if (content.Contains("ValidateContinueDistributeOnFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateContinueDistributeOnFailure = (bool?) content.GetValueForProperty("ValidateContinueDistributeOnFailure",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateContinueDistributeOnFailure, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ValidateSourceValidationOnly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateSourceValidationOnly = (bool?) content.GetValueForProperty("ValidateSourceValidationOnly",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateSourceValidationOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ValidateInVMValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateInVMValidation = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateInVMValidator[]) content.GetValueForProperty("ValidateInVMValidation",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ValidateInVMValidation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplateInVMValidator>(__y, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateInVMValidatorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorCode = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode?) content.GetValueForProperty("ProvisioningErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).ProvisioningErrorCode, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode.CreateFrom);
            }
            if (content.Contains("LastRunStatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusStartTime = (global::System.DateTime?) content.GetValueForProperty("LastRunStatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRunStatusEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusEndTime = (global::System.DateTime?) content.GetValueForProperty("LastRunStatusEndTime",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRunStatusRunSubState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunSubState = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunSubState?) content.GetValueForProperty("LastRunStatusRunSubState",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusRunSubState, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunSubState.CreateFrom);
            }
            if (content.Contains("LastRunStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusMessage = (string) content.GetValueForProperty("LastRunStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).LastRunStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("VMProfileVnetConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVnetConfig = (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IVirtualNetworkConfig) content.GetValueForProperty("VMProfileVnetConfig",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVnetConfig, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.VirtualNetworkConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMProfileVmsize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVmsize = (string) content.GetValueForProperty("VMProfileVmsize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileVmsize, global::System.Convert.ToString);
            }
            if (content.Contains("VMProfileOsdiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileOsdiskSizeGb = (int?) content.GetValueForProperty("VMProfileOsdiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileOsdiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMProfileUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileUserAssignedIdentity = (string[]) content.GetValueForProperty("VMProfileUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VMProfileUserAssignedIdentity, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VnetConfigSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigSubnetId = (string) content.GetValueForProperty("VnetConfigSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigProxyVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigProxyVMSize = (string) content.GetValueForProperty("VnetConfigProxyVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.IImageTemplatePropertiesInternal)this).VnetConfigProxyVMSize, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the properties of an image template
    [System.ComponentModel.TypeConverter(typeof(ImageTemplatePropertiesTypeConverter))]
    public partial interface IImageTemplateProperties

    {

    }
}