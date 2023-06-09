// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Extensions;

    public partial class AutomanageIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject into a new instance of <see cref="AutomanageIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AutomanageIdentity(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_bestPracticeName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("bestPracticeName"), out var __jsonBestPracticeName) ? (string)__jsonBestPracticeName : (string)BestPracticeName;}
            {_versionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("versionName"), out var __jsonVersionName) ? (string)__jsonVersionName : (string)VersionName;}
            {_configurationProfileName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("configurationProfileName"), out var __jsonConfigurationProfileName) ? (string)__jsonConfigurationProfileName : (string)ConfigurationProfileName;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_configurationProfileAssignmentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("configurationProfileAssignmentName"), out var __jsonConfigurationProfileAssignmentName) ? (string)__jsonConfigurationProfileAssignmentName : (string)ConfigurationProfileAssignmentName;}
            {_vMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("vmName"), out var __jsonVMName) ? (string)__jsonVMName : (string)VMName;}
            {_machineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("machineName"), out var __jsonMachineName) ? (string)__jsonMachineName : (string)MachineName;}
            {_clusterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("clusterName"), out var __jsonClusterName) ? (string)__jsonClusterName : (string)ClusterName;}
            {_reportName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("reportName"), out var __jsonReportName) ? (string)__jsonReportName : (string)ReportName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.IAutomanageIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.IAutomanageIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.IAutomanageIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject json ? new AutomanageIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AutomanageIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AutomanageIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._bestPracticeName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._bestPracticeName.ToString()) : null, "bestPracticeName" ,container.Add );
            AddIf( null != (((object)this._versionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._versionName.ToString()) : null, "versionName" ,container.Add );
            AddIf( null != (((object)this._configurationProfileName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._configurationProfileName.ToString()) : null, "configurationProfileName" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._configurationProfileAssignmentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._configurationProfileAssignmentName.ToString()) : null, "configurationProfileAssignmentName" ,container.Add );
            AddIf( null != (((object)this._vMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._vMName.ToString()) : null, "vmName" ,container.Add );
            AddIf( null != (((object)this._machineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._machineName.ToString()) : null, "machineName" ,container.Add );
            AddIf( null != (((object)this._clusterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._clusterName.ToString()) : null, "clusterName" ,container.Add );
            AddIf( null != (((object)this._reportName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._reportName.ToString()) : null, "reportName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}