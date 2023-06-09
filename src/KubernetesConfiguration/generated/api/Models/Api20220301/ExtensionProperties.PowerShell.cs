// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.PowerShell;

    /// <summary>Properties of an Extension resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial class ExtensionProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("AksAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AksAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesAksAssignedIdentity) content.GetValueForProperty("AksAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AksAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesAksAssignedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReleaseTrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstalledVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).InstalledVersion = (string) content.GetValueForProperty("InstalledVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).InstalledVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Statuses"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("CustomLocationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).CustomLocationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesCustomLocationSettings) content.GetValueForProperty("CustomLocationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).CustomLocationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesCustomLocationSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PackageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).PackageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeClusterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeNamespaceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClusterReleaseNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("NamespaceTargetNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoTarget = (string) content.GetValueForProperty("ErrorInfoTarget",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoDetail = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorInfoDetail",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorInfoAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[]) content.GetValueForProperty("ErrorInfoAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("AkAssignedIdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityPrincipalId = (string) content.GetValueForProperty("AkAssignedIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("AkAssignedIdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityTenantId = (string) content.GetValueForProperty("AkAssignedIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AkAssignedIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityType = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.AksIdentityType?) content.GetValueForProperty("AkAssignedIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityType, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.AksIdentityType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("AksAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AksAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesAksAssignedIdentity) content.GetValueForProperty("AksAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AksAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesAksAssignedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReleaseTrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstalledVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).InstalledVersion = (string) content.GetValueForProperty("InstalledVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).InstalledVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Statuses"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("CustomLocationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).CustomLocationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesCustomLocationSettings) content.GetValueForProperty("CustomLocationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).CustomLocationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ExtensionPropertiesCustomLocationSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PackageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).PackageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeClusterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.ScopeNamespaceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClusterReleaseNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("NamespaceTargetNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoTarget = (string) content.GetValueForProperty("ErrorInfoTarget",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorInfoDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoDetail = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorInfoDetail",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorInfoAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[]) content.GetValueForProperty("ErrorInfoAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("AkAssignedIdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityPrincipalId = (string) content.GetValueForProperty("AkAssignedIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("AkAssignedIdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityTenantId = (string) content.GetValueForProperty("AkAssignedIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AkAssignedIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityType = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.AksIdentityType?) content.GetValueForProperty("AkAssignedIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionPropertiesInternal)this).AkAssignedIdentityType, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.AksIdentityType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExtensionProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtensionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of an Extension resource
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial interface IExtensionProperties

    {

    }
}