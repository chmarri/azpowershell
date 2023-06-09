// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>Describes the basic gallery artifact publishing profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryArtifactPublishingProfileBaseTypeConverter))]
    public partial class GalleryArtifactPublishingProfileBase
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryArtifactPublishingProfileBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryArtifactPublishingProfileBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryArtifactPublishingProfileBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryArtifactPublishingProfileBase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryArtifactPublishingProfileBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="GalleryArtifactPublishingProfileBase" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryArtifactPublishingProfileBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryArtifactPublishingProfileBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TargetRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetRegion = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[]) content.GetValueForProperty("TargetRegion",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetRegion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.TargetRegionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplicaCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicaCount = (int?) content.GetValueForProperty("ReplicaCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicaCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExcludeFromLatest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ExcludeFromLatest = (bool?) content.GetValueForProperty("ExcludeFromLatest",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ExcludeFromLatest, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PublishedDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).PublishedDate = (global::System.DateTime?) content.GetValueForProperty("PublishedDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).PublishedDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndOfLifeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).StorageAccountType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType?) content.GetValueForProperty("StorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).StorageAccountType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType.CreateFrom);
            }
            if (content.Contains("ReplicationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicationMode = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode?) content.GetValueForProperty("ReplicationMode",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicationMode, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode.CreateFrom);
            }
            if (content.Contains("TargetExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[]) content.GetValueForProperty("TargetExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetExtendedLocation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryTargetExtendedLocationTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryArtifactPublishingProfileBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryArtifactPublishingProfileBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TargetRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetRegion = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[]) content.GetValueForProperty("TargetRegion",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetRegion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.TargetRegionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplicaCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicaCount = (int?) content.GetValueForProperty("ReplicaCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicaCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExcludeFromLatest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ExcludeFromLatest = (bool?) content.GetValueForProperty("ExcludeFromLatest",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ExcludeFromLatest, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PublishedDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).PublishedDate = (global::System.DateTime?) content.GetValueForProperty("PublishedDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).PublishedDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndOfLifeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).StorageAccountType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType?) content.GetValueForProperty("StorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).StorageAccountType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType.CreateFrom);
            }
            if (content.Contains("ReplicationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicationMode = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode?) content.GetValueForProperty("ReplicationMode",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).ReplicationMode, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode.CreateFrom);
            }
            if (content.Contains("TargetExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[]) content.GetValueForProperty("TargetExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal)this).TargetExtendedLocation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryTargetExtendedLocationTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the basic gallery artifact publishing profile.
    [System.ComponentModel.TypeConverter(typeof(GalleryArtifactPublishingProfileBaseTypeConverter))]
    public partial interface IGalleryArtifactPublishingProfileBase

    {

    }
}