// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Extensions;

    /// <summary>
    /// An Activity Log Alert rule condition that is met when all its member conditions are met.
    /// Each condition can be of one of the following types:
    /// __Important__: Each type has its unique subset of properties. Properties from different types CANNOT exist in one condition.
    /// * __Leaf Condition -__ must contain 'field' and either 'equals' or 'containsAny'.
    /// _Please note, 'anyOf' should __not__ be set in a Leaf Condition._
    /// * __AnyOf Condition -__ must contain __only__ 'anyOf' (which is an array of Leaf Conditions).
    /// _Please note, 'field', 'equals' and 'containsAny' should __not__ be set in an AnyOf Condition._
    /// </summary>
    public partial class AlertRuleAnyOfOrLeafCondition
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject into a new instance of <see cref="AlertRuleAnyOfOrLeafCondition" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AlertRuleAnyOfOrLeafCondition(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __alertRuleLeafCondition = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.AlertRuleLeafCondition(json);
            {_anyOf = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonArray>("anyOf"), out var __jsonAnyOf) ? If( __jsonAnyOf as Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleLeafCondition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleLeafCondition) (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.AlertRuleLeafCondition.FromJson(__u) )) ))() : null : AnyOf;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject json ? new AlertRuleAnyOfOrLeafCondition(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AlertRuleAnyOfOrLeafCondition" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AlertRuleAnyOfOrLeafCondition" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __alertRuleLeafCondition?.ToJson(container, serializationMode);
            if (null != this._anyOf)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Json.XNodeArray();
                foreach( var __x in this._anyOf )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("anyOf",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}