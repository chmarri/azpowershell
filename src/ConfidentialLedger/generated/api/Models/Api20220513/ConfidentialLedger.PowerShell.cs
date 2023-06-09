// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513
{
    using Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.PowerShell;

    /// <summary>Confidential Ledger. Contains the properties of Confidential Ledger Resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfidentialLedgerTypeConverter))]
    public partial class ConfidentialLedger
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ConfidentialLedger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConfidentialLedger(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ILedgerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.LedgerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceLocationInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceLocationInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags1Internal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags1Internal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LedgerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.LedgerType?) content.GetValueForProperty("LedgerType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.LedgerType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("LedgerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerName = (string) content.GetValueForProperty("LedgerName",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerName, global::System.Convert.ToString);
            }
            if (content.Contains("LedgerUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerUri = (string) content.GetValueForProperty("LedgerUri",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerUri, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityServiceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).IdentityServiceUri = (string) content.GetValueForProperty("IdentityServiceUri",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).IdentityServiceUri, global::System.Convert.ToString);
            }
            if (content.Contains("LedgerInternalNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerInternalNamespace = (string) content.GetValueForProperty("LedgerInternalNamespace",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerInternalNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("AadBasedSecurityPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).AadBasedSecurityPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IAadBasedSecurityPrincipal[]) content.GetValueForProperty("AadBasedSecurityPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).AadBasedSecurityPrincipal, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IAadBasedSecurityPrincipal>(__y, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.AadBasedSecurityPrincipalTypeConverter.ConvertFrom));
            }
            if (content.Contains("CertBasedSecurityPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).CertBasedSecurityPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ICertBasedSecurityPrincipal[]) content.GetValueForProperty("CertBasedSecurityPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).CertBasedSecurityPrincipal, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ICertBasedSecurityPrincipal>(__y, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.CertBasedSecurityPrincipalTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ConfidentialLedger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConfidentialLedger(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ILedgerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.LedgerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceLocationInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceLocationInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags1Internal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ITags1Internal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LedgerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerType = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.LedgerType?) content.GetValueForProperty("LedgerType",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerType, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.LedgerType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("LedgerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerName = (string) content.GetValueForProperty("LedgerName",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerName, global::System.Convert.ToString);
            }
            if (content.Contains("LedgerUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerUri = (string) content.GetValueForProperty("LedgerUri",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerUri, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityServiceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).IdentityServiceUri = (string) content.GetValueForProperty("IdentityServiceUri",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).IdentityServiceUri, global::System.Convert.ToString);
            }
            if (content.Contains("LedgerInternalNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerInternalNamespace = (string) content.GetValueForProperty("LedgerInternalNamespace",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).LedgerInternalNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("AadBasedSecurityPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).AadBasedSecurityPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IAadBasedSecurityPrincipal[]) content.GetValueForProperty("AadBasedSecurityPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).AadBasedSecurityPrincipal, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IAadBasedSecurityPrincipal>(__y, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.AadBasedSecurityPrincipalTypeConverter.ConvertFrom));
            }
            if (content.Contains("CertBasedSecurityPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).CertBasedSecurityPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ICertBasedSecurityPrincipal[]) content.GetValueForProperty("CertBasedSecurityPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedgerInternal)this).CertBasedSecurityPrincipal, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ICertBasedSecurityPrincipal>(__y, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.CertBasedSecurityPrincipalTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ConfidentialLedger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedger"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedger DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConfidentialLedger(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ConfidentialLedger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedger"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedger DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConfidentialLedger(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConfidentialLedger" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ConfidentialLedger" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IConfidentialLedger FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Confidential Ledger. Contains the properties of Confidential Ledger Resource.
    [System.ComponentModel.TypeConverter(typeof(ConfidentialLedgerTypeConverter))]
    public partial interface IConfidentialLedger

    {

    }
}