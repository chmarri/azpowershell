// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.PowerShell;

    /// <summary>The delivery information associated with a export.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExportDeliveryInfoTypeConverter))]
    public partial class ExportDeliveryInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExportDeliveryInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExportDeliveryInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExportDeliveryInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Destination"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).Destination = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryDestination) content.GetValueForProperty("Destination",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).Destination, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryDestinationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DestinationResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationResourceId = (string) content.GetValueForProperty("DestinationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationContainer = (string) content.GetValueForProperty("DestinationContainer",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationContainer, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationRootFolderPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationRootFolderPath = (string) content.GetValueForProperty("DestinationRootFolderPath",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationRootFolderPath, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationSasToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationSasToken = (string) content.GetValueForProperty("DestinationSasToken",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationSasToken, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationStorageAccount = (string) content.GetValueForProperty("DestinationStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationStorageAccount, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExportDeliveryInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Destination"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).Destination = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryDestination) content.GetValueForProperty("Destination",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).Destination, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ExportDeliveryDestinationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DestinationResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationResourceId = (string) content.GetValueForProperty("DestinationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationContainer = (string) content.GetValueForProperty("DestinationContainer",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationContainer, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationRootFolderPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationRootFolderPath = (string) content.GetValueForProperty("DestinationRootFolderPath",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationRootFolderPath, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationSasToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationSasToken = (string) content.GetValueForProperty("DestinationSasToken",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationSasToken, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationStorageAccount = (string) content.GetValueForProperty("DestinationStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfoInternal)this).DestinationStorageAccount, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExportDeliveryInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExportDeliveryInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IExportDeliveryInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The delivery information associated with a export.
    [System.ComponentModel.TypeConverter(typeof(ExportDeliveryInfoTypeConverter))]
    public partial interface IExportDeliveryInfo

    {

    }
}