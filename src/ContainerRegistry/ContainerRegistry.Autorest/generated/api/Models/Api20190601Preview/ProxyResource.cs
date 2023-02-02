// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>
    /// The resource model definition for a ARM proxy resource. It will have everything other than required location and tags.
    /// </summary>
    public partial class ProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResource,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource modification (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType)""); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
        {

        }
    }
    /// The resource model definition for a ARM proxy resource. It will have everything other than required location and tags.
    public partial interface IProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource modification (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource modification (UTC).",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The resource model definition for a ARM proxy resource. It will have everything other than required location and tags.
    internal partial interface IProxyResourceInternal

    {
        /// <summary>The resource ID.</summary>
        string Id { get; set; }
        /// <summary>The name of the resource.</summary>
        string Name { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource modification (UTC).</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}