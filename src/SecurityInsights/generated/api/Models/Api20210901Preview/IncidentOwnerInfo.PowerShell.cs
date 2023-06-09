// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Information on the user an incident is assigned to</summary>
    [System.ComponentModel.TypeConverter(typeof(IncidentOwnerInfoTypeConverter))]
    public partial class IncidentOwnerInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IncidentOwnerInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IncidentOwnerInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IncidentOwnerInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IncidentOwnerInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IncidentOwnerInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Email"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).Email = (string) content.GetValueForProperty("Email",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).Email, global::System.Convert.ToString);
            }
            if (content.Contains("AssignedTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).AssignedTo = (string) content.GetValueForProperty("AssignedTo",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).AssignedTo, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).ObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("UserPrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).UserPrincipalName, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).OwnerType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType?) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).OwnerType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IncidentOwnerInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Email"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).Email = (string) content.GetValueForProperty("Email",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).Email, global::System.Convert.ToString);
            }
            if (content.Contains("AssignedTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).AssignedTo = (string) content.GetValueForProperty("AssignedTo",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).AssignedTo, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).ObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("UserPrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).UserPrincipalName, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).OwnerType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType?) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfoInternal)this).OwnerType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Information on the user an incident is assigned to
    [System.ComponentModel.TypeConverter(typeof(IncidentOwnerInfoTypeConverter))]
    public partial interface IIncidentOwnerInfo

    {

    }
}