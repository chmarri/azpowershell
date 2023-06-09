// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>
    /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(EncryptionImagesTypeConverter))]
    public partial class EncryptionImages
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.EncryptionImages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImages" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImages DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EncryptionImages(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.EncryptionImages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImages" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImages DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EncryptionImages(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.EncryptionImages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EncryptionImages(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OSDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IOSDiskImageEncryption) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.OSDiskImageEncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDataDiskImageEncryption[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDataDiskImageEncryption>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.DataDiskImageEncryptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("OSDiskImageDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageDiskEncryptionSetId = (string) content.GetValueForProperty("OSDiskImageDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageDiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskImageSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IOSDiskImageSecurityProfile) content.GetValueForProperty("OSDiskImageSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.OSDiskImageSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileConfidentialVMEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileConfidentialVMEncryptionType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ConfidentialVMEncryptionType?) content.GetValueForProperty("SecurityProfileConfidentialVMEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileConfidentialVMEncryptionType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ConfidentialVMEncryptionType.CreateFrom);
            }
            if (content.Contains("SecurityProfileSecureVMDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileSecureVMDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileSecureVMDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileSecureVMDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.EncryptionImages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EncryptionImages(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OSDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IOSDiskImageEncryption) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.OSDiskImageEncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDataDiskImageEncryption[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IDataDiskImageEncryption>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.DataDiskImageEncryptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("OSDiskImageDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageDiskEncryptionSetId = (string) content.GetValueForProperty("OSDiskImageDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageDiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskImageSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IOSDiskImageSecurityProfile) content.GetValueForProperty("OSDiskImageSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).OSDiskImageSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.OSDiskImageSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileConfidentialVMEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileConfidentialVMEncryptionType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ConfidentialVMEncryptionType?) content.GetValueForProperty("SecurityProfileConfidentialVMEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileConfidentialVMEncryptionType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ConfidentialVMEncryptionType.CreateFrom);
            }
            if (content.Contains("SecurityProfileSecureVMDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileSecureVMDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileSecureVMDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImagesInternal)this).SecurityProfileSecureVMDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EncryptionImages" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EncryptionImages" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IEncryptionImages FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
    [System.ComponentModel.TypeConverter(typeof(EncryptionImagesTypeConverter))]
    public partial interface IEncryptionImages

    {

    }
}