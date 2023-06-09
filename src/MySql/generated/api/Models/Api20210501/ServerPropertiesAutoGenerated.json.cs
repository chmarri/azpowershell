// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a server.</summary>
    public partial class ServerPropertiesAutoGenerated
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesAutoGenerated FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json ? new ServerPropertiesAutoGenerated(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject into a new instance of <see cref="ServerPropertiesAutoGenerated" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServerPropertiesAutoGenerated(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject>("storage"), out var __jsonStorage) ? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Storage.FromJson(__jsonStorage) : Storage;}
            {_backup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject>("backup"), out var __jsonBackup) ? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Backup.FromJson(__jsonBackup) : Backup;}
            {_highAvailability = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject>("highAvailability"), out var __jsonHighAvailability) ? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.HighAvailability.FromJson(__jsonHighAvailability) : HighAvailability;}
            {_network = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject>("network"), out var __jsonNetwork) ? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Network.FromJson(__jsonNetwork) : Network;}
            {_maintenanceWindow = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject>("maintenanceWindow"), out var __jsonMaintenanceWindow) ? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.MaintenanceWindow.FromJson(__jsonMaintenanceWindow) : MaintenanceWindow;}
            {_administratorLogin = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("administratorLogin"), out var __jsonAdministratorLogin) ? (string)__jsonAdministratorLogin : (string)AdministratorLogin;}
            {_administratorLoginPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("administratorLoginPassword"), out var __jsonAdministratorLoginPassword) ? new System.Net.NetworkCredential("",(string)__jsonAdministratorLoginPassword).SecurePassword : AdministratorLoginPassword;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("availabilityZone"), out var __jsonAvailabilityZone) ? (string)__jsonAvailabilityZone : (string)AvailabilityZone;}
            {_createMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("createMode"), out var __jsonCreateMode) ? (string)__jsonCreateMode : (string)CreateMode;}
            {_sourceServerResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("sourceServerResourceId"), out var __jsonSourceServerResourceId) ? (string)__jsonSourceServerResourceId : (string)SourceServerResourceId;}
            {_restorePointInTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("restorePointInTime"), out var __jsonRestorePointInTime) ? global::System.DateTime.TryParse((string)__jsonRestorePointInTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonRestorePointInTimeValue) ? __jsonRestorePointInTimeValue : RestorePointInTime : RestorePointInTime;}
            {_replicationRole = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("replicationRole"), out var __jsonReplicationRole) ? (string)__jsonReplicationRole : (string)ReplicationRole;}
            {_replicaCapacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNumber>("replicaCapacity"), out var __jsonReplicaCapacity) ? (int?)__jsonReplicaCapacity : ReplicaCapacity;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_fullyQualifiedDomainName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("fullyQualifiedDomainName"), out var __jsonFullyQualifiedDomainName) ? (string)__jsonFullyQualifiedDomainName : (string)FullyQualifiedDomainName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServerPropertiesAutoGenerated" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServerPropertiesAutoGenerated" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._storage ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) this._storage.ToJson(null,serializationMode) : null, "storage" ,container.Add );
            AddIf( null != this._backup ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) this._backup.ToJson(null,serializationMode) : null, "backup" ,container.Add );
            AddIf( null != this._highAvailability ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) this._highAvailability.ToJson(null,serializationMode) : null, "highAvailability" ,container.Add );
            AddIf( null != this._network ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) this._network.ToJson(null,serializationMode) : null, "network" ,container.Add );
            AddIf( null != this._maintenanceWindow ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) this._maintenanceWindow.ToJson(null,serializationMode) : null, "maintenanceWindow" ,container.Add );
            AddIf( null != (((object)this._administratorLogin)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._administratorLogin.ToString()) : null, "administratorLogin" ,container.Add );
            AddIf( null != (((object)this._administratorLoginPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._administratorLoginPassword))) : null, "administratorLoginPassword" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AddIf( null != (((object)this._availabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._availabilityZone.ToString()) : null, "availabilityZone" ,container.Add );
            AddIf( null != (((object)this._createMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._createMode.ToString()) : null, "createMode" ,container.Add );
            AddIf( null != (((object)this._sourceServerResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._sourceServerResourceId.ToString()) : null, "sourceServerResourceId" ,container.Add );
            AddIf( null != this._restorePointInTime ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._restorePointInTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "restorePointInTime" ,container.Add );
            AddIf( null != (((object)this._replicationRole)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._replicationRole.ToString()) : null, "replicationRole" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._replicaCapacity ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNumber((int)this._replicaCapacity) : null, "replicaCapacity" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._fullyQualifiedDomainName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._fullyQualifiedDomainName.ToString()) : null, "fullyQualifiedDomainName" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}