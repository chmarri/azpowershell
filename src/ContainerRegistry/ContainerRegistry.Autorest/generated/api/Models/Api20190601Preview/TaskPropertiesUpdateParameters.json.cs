// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties for updating a task.</summary>
    public partial class TaskPropertiesUpdateParameters
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json ? new TaskPropertiesUpdateParameters(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject into a new instance of <see cref="TaskPropertiesUpdateParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal TaskPropertiesUpdateParameters(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_platform = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("platform"), out var __jsonPlatform) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.PlatformUpdateParameters.FromJson(__jsonPlatform) : Platform;}
            {_agentConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("agentConfiguration"), out var __jsonAgentConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentProperties.FromJson(__jsonAgentConfiguration) : AgentConfiguration;}
            {_step = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("step"), out var __jsonStep) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TaskStepUpdateParameters.FromJson(__jsonStep) : Step;}
            {_trigger = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("trigger"), out var __jsonTrigger) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TriggerUpdateParameters.FromJson(__jsonTrigger) : Trigger;}
            {_credentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject>("credentials"), out var __jsonCredentials) ? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.Credentials.FromJson(__jsonCredentials) : Credentials;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_agentPoolName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("agentPoolName"), out var __jsonAgentPoolName) ? (string)__jsonAgentPoolName : (string)AgentPoolName;}
            {_timeout = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNumber>("timeout"), out var __jsonTimeout) ? (int?)__jsonTimeout : Timeout;}
            {_logTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString>("logTemplate"), out var __jsonLogTemplate) ? (string)__jsonLogTemplate : (string)LogTemplate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="TaskPropertiesUpdateParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="TaskPropertiesUpdateParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._platform ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._platform.ToJson(null,serializationMode) : null, "platform" ,container.Add );
            AddIf( null != this._agentConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._agentConfiguration.ToJson(null,serializationMode) : null, "agentConfiguration" ,container.Add );
            AddIf( null != this._step ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._step.ToJson(null,serializationMode) : null, "step" ,container.Add );
            AddIf( null != this._trigger ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._trigger.ToJson(null,serializationMode) : null, "trigger" ,container.Add );
            AddIf( null != this._credentials ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) this._credentials.ToJson(null,serializationMode) : null, "credentials" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._agentPoolName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._agentPoolName.ToString()) : null, "agentPoolName" ,container.Add );
            AddIf( null != this._timeout ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNumber((int)this._timeout) : null, "timeout" ,container.Add );
            AddIf( null != (((object)this._logTemplate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonString(this._logTemplate.ToString()) : null, "logTemplate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}