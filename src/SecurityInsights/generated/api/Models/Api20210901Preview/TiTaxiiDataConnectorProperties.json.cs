// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Threat Intelligence TAXII data connector properties.</summary>
    public partial class TiTaxiiDataConnectorProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ITiTaxiiDataConnectorProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ITiTaxiiDataConnectorProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ITiTaxiiDataConnectorProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json ? new TiTaxiiDataConnectorProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject into a new instance of <see cref="TiTaxiiDataConnectorProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal TiTaxiiDataConnectorProperties(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __dataConnectorTenantId = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorTenantId(json);
            {_dataType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject>("dataTypes"), out var __jsonDataTypes) ? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.TiTaxiiDataConnectorDataTypes.FromJson(__jsonDataTypes) : DataType;}
            {_workspaceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("workspaceId"), out var __jsonWorkspaceId) ? (string)__jsonWorkspaceId : (string)WorkspaceId;}
            {_friendlyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("friendlyName"), out var __jsonFriendlyName) ? (string)__jsonFriendlyName : (string)FriendlyName;}
            {_taxiiServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("taxiiServer"), out var __jsonTaxiiServer) ? (string)__jsonTaxiiServer : (string)TaxiiServer;}
            {_collectionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("collectionId"), out var __jsonCollectionId) ? (string)__jsonCollectionId : (string)CollectionId;}
            {_userName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            {_password = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_taxiiLookbackPeriod = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("taxiiLookbackPeriod"), out var __jsonTaxiiLookbackPeriod) ? global::System.DateTime.TryParse((string)__jsonTaxiiLookbackPeriod, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTaxiiLookbackPeriodValue) ? __jsonTaxiiLookbackPeriodValue : TaxiiLookbackPeriod : TaxiiLookbackPeriod;}
            {_pollingFrequency = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("pollingFrequency"), out var __jsonPollingFrequency) ? (string)__jsonPollingFrequency : (string)PollingFrequency;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="TiTaxiiDataConnectorProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="TiTaxiiDataConnectorProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __dataConnectorTenantId?.ToJson(container, serializationMode);
            AddIf( null != this._dataType ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) this._dataType.ToJson(null,serializationMode) : null, "dataTypes" ,container.Add );
            AddIf( null != (((object)this._workspaceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._workspaceId.ToString()) : null, "workspaceId" ,container.Add );
            AddIf( null != (((object)this._friendlyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._friendlyName.ToString()) : null, "friendlyName" ,container.Add );
            AddIf( null != (((object)this._taxiiServer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._taxiiServer.ToString()) : null, "taxiiServer" ,container.Add );
            AddIf( null != (((object)this._collectionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._collectionId.ToString()) : null, "collectionId" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != this._taxiiLookbackPeriod ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._taxiiLookbackPeriod?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "taxiiLookbackPeriod" ,container.Add );
            AddIf( null != (((object)this._pollingFrequency)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._pollingFrequency.ToString()) : null, "pollingFrequency" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}