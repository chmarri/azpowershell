// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Represents a SourceControl in Azure Security Insights.</summary>
    [System.ComponentModel.TypeConverter(typeof(SourceControlTypeConverter))]
    public partial class SourceControl
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControl"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControl DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SourceControl(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControl"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControl DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SourceControl(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SourceControl" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SourceControl" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControl FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SourceControl(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControlPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Repository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Repository = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IRepository) content.GetValueForProperty("Repository",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Repository, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.RepositoryTypeConverter.ConvertFrom);
            }
            if (content.Contains("RepoType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepoType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.RepoType) content.GetValueForProperty("RepoType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepoType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.RepoType.CreateFrom);
            }
            if (content.Contains("PropertiesId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).PropertiesId = (string) content.GetValueForProperty("PropertiesId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).PropertiesId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).ContentType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType[]) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).ContentType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType.CreateFrom));
            }
            if (content.Contains("RepositoryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryUrl = (string) content.GetValueForProperty("RepositoryUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryBranch = (string) content.GetValueForProperty("RepositoryBranch",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryBranch, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryDisplayUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDisplayUrl = (string) content.GetValueForProperty("RepositoryDisplayUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDisplayUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryPathMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryPathMapping = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IContentPathMap[]) content.GetValueForProperty("RepositoryPathMapping",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryPathMapping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IContentPathMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ContentPathMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("RepositoryDeploymentLogsUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDeploymentLogsUrl = (string) content.GetValueForProperty("RepositoryDeploymentLogsUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDeploymentLogsUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControl"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SourceControl(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SourceControlPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Repository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Repository = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IRepository) content.GetValueForProperty("Repository",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Repository, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.RepositoryTypeConverter.ConvertFrom);
            }
            if (content.Contains("RepoType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepoType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.RepoType) content.GetValueForProperty("RepoType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepoType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.RepoType.CreateFrom);
            }
            if (content.Contains("PropertiesId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).PropertiesId = (string) content.GetValueForProperty("PropertiesId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).PropertiesId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).ContentType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType[]) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).ContentType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ContentType.CreateFrom));
            }
            if (content.Contains("RepositoryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryUrl = (string) content.GetValueForProperty("RepositoryUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryBranch = (string) content.GetValueForProperty("RepositoryBranch",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryBranch, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryDisplayUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDisplayUrl = (string) content.GetValueForProperty("RepositoryDisplayUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDisplayUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RepositoryPathMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryPathMapping = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IContentPathMap[]) content.GetValueForProperty("RepositoryPathMapping",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryPathMapping, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IContentPathMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ContentPathMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("RepositoryDeploymentLogsUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDeploymentLogsUrl = (string) content.GetValueForProperty("RepositoryDeploymentLogsUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISourceControlInternal)this).RepositoryDeploymentLogsUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents a SourceControl in Azure Security Insights.
    [System.ComponentModel.TypeConverter(typeof(SourceControlTypeConverter))]
    public partial interface ISourceControl

    {

    }
}