// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The response properties returned for a pipeline run.</summary>
    public partial class PipelineRunResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.IPipelineRunResponse FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json ? new PipelineRunResponse(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject into a new instance of <see cref="PipelineRunResponse" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PipelineRunResponse(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_progress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("progress"), out var __jsonProgress) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ProgressProperties.FromJson(__jsonProgress) : Progress;}
            {_source = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("source"), out var __jsonSource) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ImportPipelineSourceProperties.FromJson(__jsonSource) : Source;}
            {_target = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("target"), out var __jsonTarget) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ExportPipelineTargetProperties.FromJson(__jsonTarget) : Target;}
            {_trigger = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("trigger"), out var __jsonTrigger) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.PipelineTriggerDescriptor.FromJson(__jsonTrigger) : Trigger;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_importedArtifact = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonArray>("importedArtifacts"), out var __jsonImportedArtifacts) ? If( __jsonImportedArtifacts as Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : ImportedArtifact;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : StartTime : StartTime;}
            {_finishTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("finishTime"), out var __jsonFinishTime) ? global::System.DateTime.TryParse((string)__jsonFinishTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonFinishTimeValue) ? __jsonFinishTimeValue : FinishTime : FinishTime;}
            {_catalogDigest = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("catalogDigest"), out var __jsonCatalogDigest) ? (string)__jsonCatalogDigest : (string)CatalogDigest;}
            {_pipelineRunErrorMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("pipelineRunErrorMessage"), out var __jsonPipelineRunErrorMessage) ? (string)__jsonPipelineRunErrorMessage : (string)PipelineRunErrorMessage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PipelineRunResponse" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PipelineRunResponse" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._progress ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._progress.ToJson(null,serializationMode) : null, "progress" ,container.Add );
            AddIf( null != this._source ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._source.ToJson(null,serializationMode) : null, "source" ,container.Add );
            AddIf( null != this._target ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._target.ToJson(null,serializationMode) : null, "target" ,container.Add );
            AddIf( null != this._trigger ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._trigger.ToJson(null,serializationMode) : null, "trigger" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            if (null != this._importedArtifact)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.XNodeArray();
                foreach( var __x in this._importedArtifact )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("importedArtifacts",__w);
            }
            AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            AddIf( null != this._finishTime ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._finishTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "finishTime" ,container.Add );
            AddIf( null != (((object)this._catalogDigest)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._catalogDigest.ToString()) : null, "catalogDigest" ,container.Add );
            AddIf( null != (((object)this._pipelineRunErrorMessage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._pipelineRunErrorMessage.ToString()) : null, "pipelineRunErrorMessage" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}