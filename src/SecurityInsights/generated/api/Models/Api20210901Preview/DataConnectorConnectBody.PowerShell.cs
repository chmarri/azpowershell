// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Represents Codeless API Polling data connector.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataConnectorConnectBodyTypeConverter))]
    public partial class DataConnectorConnectBody
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorConnectBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataConnectorConnectBody(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectAuthKind?) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectAuthKind.CreateFrom);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).AuthorizationCode = (string) content.GetValueForProperty("AuthorizationCode",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).AuthorizationCode, global::System.Convert.ToString);
            }
            if (content.Contains("UserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("RequestConfigUserInputValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).RequestConfigUserInputValue = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny[]) content.GetValueForProperty("RequestConfigUserInputValue",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).RequestConfigUserInputValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorConnectBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataConnectorConnectBody(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectAuthKind?) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectAuthKind.CreateFrom);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientSecret = (string) content.GetValueForProperty("ClientSecret",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientSecret, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).AuthorizationCode = (string) content.GetValueForProperty("AuthorizationCode",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).AuthorizationCode, global::System.Convert.ToString);
            }
            if (content.Contains("UserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("RequestConfigUserInputValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).RequestConfigUserInputValue = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny[]) content.GetValueForProperty("RequestConfigUserInputValue",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBodyInternal)this).RequestConfigUserInputValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorConnectBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBody"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBody DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataConnectorConnectBody(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorConnectBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBody"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBody DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataConnectorConnectBody(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataConnectorConnectBody" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataConnectorConnectBody" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorConnectBody FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents Codeless API Polling data connector.
    [System.ComponentModel.TypeConverter(typeof(DataConnectorConnectBodyTypeConverter))]
    public partial interface IDataConnectorConnectBody

    {

    }
}