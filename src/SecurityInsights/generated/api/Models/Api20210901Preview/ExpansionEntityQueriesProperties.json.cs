// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Describes expansion entity query properties</summary>
    public partial class ExpansionEntityQueriesProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject into a new instance of <see cref="ExpansionEntityQueriesProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExpansionEntityQueriesProperties(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_dataSource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray>("dataSources"), out var __jsonDataSources) ? If( __jsonDataSources as Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : DataSource;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_inputEntityType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("inputEntityType"), out var __jsonInputEntityType) ? (string)__jsonInputEntityType : (string)InputEntityType;}
            {_inputField = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray>("inputFields"), out var __jsonInputFields) ? If( __jsonInputFields as Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : InputField;}
            {_outputEntityType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray>("outputEntityTypes"), out var __jsonOutputEntityTypes) ? If( __jsonOutputEntityTypes as Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType) (__k is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString __j ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType)(__j.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType)""))) ))() : null : OutputEntityType;}
            {_queryTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("queryTemplate"), out var __jsonQueryTemplate) ? (string)__jsonQueryTemplate : (string)QueryTemplate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json ? new ExpansionEntityQueriesProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExpansionEntityQueriesProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExpansionEntityQueriesProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
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
            if (null != this._dataSource)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.XNodeArray();
                foreach( var __x in this._dataSource )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("dataSources",__w);
            }
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._inputEntityType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._inputEntityType.ToString()) : null, "inputEntityType" ,container.Add );
            if (null != this._inputField)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.XNodeArray();
                foreach( var __s in this._inputField )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("inputFields",__r);
            }
            if (null != this._outputEntityType)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.XNodeArray();
                foreach( var __n in this._outputEntityType )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("outputEntityTypes",__m);
            }
            AddIf( null != (((object)this._queryTemplate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._queryTemplate.ToString()) : null, "queryTemplate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}