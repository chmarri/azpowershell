// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Extensions;

    /// <summary>scheduled query rule Definition</summary>
    public partial class ScheduledQueryRuleProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject json ? new ScheduledQueryRuleProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject into a new instance of <see cref="ScheduledQueryRuleProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScheduledQueryRuleProperties(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_criterion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject>("criteria"), out var __jsonCriteria) ? Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ScheduledQueryRuleCriteria.FromJson(__jsonCriteria) : Criterion;}
            {_action = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject>("actions"), out var __jsonActions) ? Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Actions.FromJson(__jsonActions) : Action;}
            {_createdWithApiVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("createdWithApiVersion"), out var __jsonCreatedWithApiVersion) ? (string)__jsonCreatedWithApiVersion : (string)CreatedWithApiVersion;}
            {_isLegacyLogAnalyticsRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("isLegacyLogAnalyticsRule"), out var __jsonIsLegacyLogAnalyticsRule) ? (bool?)__jsonIsLegacyLogAnalyticsRule : IsLegacyLogAnalyticsRule;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_severity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNumber>("severity"), out var __jsonSeverity) ? (long?)__jsonSeverity : Severity;}
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : Enabled;}
            {_scope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonArray>("scopes"), out var __jsonScopes) ? If( __jsonScopes as Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Scope;}
            {_evaluationFrequency = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("evaluationFrequency"), out var __jsonEvaluationFrequency) ? global::System.Xml.XmlConvert.ToTimeSpan( __jsonEvaluationFrequency ) : EvaluationFrequency;}
            {_windowSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("windowSize"), out var __jsonWindowSize) ? global::System.Xml.XmlConvert.ToTimeSpan( __jsonWindowSize ) : WindowSize;}
            {_overrideQueryTimeRange = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("overrideQueryTimeRange"), out var __jsonOverrideQueryTimeRange) ? global::System.Xml.XmlConvert.ToTimeSpan( __jsonOverrideQueryTimeRange ) : OverrideQueryTimeRange;}
            {_targetResourceType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonArray>("targetResourceTypes"), out var __jsonTargetResourceTypes) ? If( __jsonTargetResourceTypes as Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : TargetResourceType;}
            {_muteActionsDuration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString>("muteActionsDuration"), out var __jsonMuteActionsDuration) ? global::System.Xml.XmlConvert.ToTimeSpan( __jsonMuteActionsDuration ) : MuteActionsDuration;}
            {_isWorkspaceAlertsStorageConfigured = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("isWorkspaceAlertsStorageConfigured"), out var __jsonIsWorkspaceAlertsStorageConfigured) ? (bool?)__jsonIsWorkspaceAlertsStorageConfigured : IsWorkspaceAlertsStorageConfigured;}
            {_checkWorkspaceAlertsStorageConfigured = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("checkWorkspaceAlertsStorageConfigured"), out var __jsonCheckWorkspaceAlertsStorageConfigured) ? (bool?)__jsonCheckWorkspaceAlertsStorageConfigured : CheckWorkspaceAlertsStorageConfigured;}
            {_skipQueryValidation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("skipQueryValidation"), out var __jsonSkipQueryValidation) ? (bool?)__jsonSkipQueryValidation : SkipQueryValidation;}
            {_autoMitigate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean>("autoMitigate"), out var __jsonAutoMitigate) ? (bool?)__jsonAutoMitigate : AutoMitigate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScheduledQueryRuleProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScheduledQueryRuleProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._criterion ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) this._criterion.ToJson(null,serializationMode) : null, "criteria" ,container.Add );
            AddIf( null != this._action ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) this._action.ToJson(null,serializationMode) : null, "actions" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._createdWithApiVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(this._createdWithApiVersion.ToString()) : null, "createdWithApiVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isLegacyLogAnalyticsRule ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._isLegacyLogAnalyticsRule) : null, "isLegacyLogAnalyticsRule" ,container.Add );
            }
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != this._severity ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNumber((long)this._severity) : null, "severity" ,container.Add );
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            if (null != this._scope)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.XNodeArray();
                foreach( var __x in this._scope )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("scopes",__w);
            }
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)(null != this._evaluationFrequency ? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)this._evaluationFrequency)): null), "evaluationFrequency" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)(null != this._windowSize ? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)this._windowSize)): null), "windowSize" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)(null != this._overrideQueryTimeRange ? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)this._overrideQueryTimeRange)): null), "overrideQueryTimeRange" ,container.Add );
            if (null != this._targetResourceType)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.XNodeArray();
                foreach( var __s in this._targetResourceType )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("targetResourceTypes",__r);
            }
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)(null != this._muteActionsDuration ? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)this._muteActionsDuration)): null), "muteActionsDuration" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isWorkspaceAlertsStorageConfigured ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._isWorkspaceAlertsStorageConfigured) : null, "isWorkspaceAlertsStorageConfigured" ,container.Add );
            }
            AddIf( null != this._checkWorkspaceAlertsStorageConfigured ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._checkWorkspaceAlertsStorageConfigured) : null, "checkWorkspaceAlertsStorageConfigured" ,container.Add );
            AddIf( null != this._skipQueryValidation ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._skipQueryValidation) : null, "skipQueryValidation" ,container.Add );
            AddIf( null != this._autoMitigate ? (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonBoolean((bool)this._autoMitigate) : null, "autoMitigate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}