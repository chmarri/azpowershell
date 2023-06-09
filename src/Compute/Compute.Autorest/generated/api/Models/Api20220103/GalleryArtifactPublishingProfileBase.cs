// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the basic gallery artifact publishing profile.</summary>
    public partial class GalleryArtifactPublishingProfileBase :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBase,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal
    {

        /// <summary>Backing field for <see cref="EndOfLifeDate" /> property.</summary>
        private global::System.DateTime? _endOfLifeDate;

        /// <summary>
        /// The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property
        /// is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public global::System.DateTime? EndOfLifeDate { get => this._endOfLifeDate; set => this._endOfLifeDate = value; }

        /// <summary>Backing field for <see cref="ExcludeFromLatest" /> property.</summary>
        private bool? _excludeFromLatest;

        /// <summary>
        /// If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public bool? ExcludeFromLatest { get => this._excludeFromLatest; set => this._excludeFromLatest = value; }

        /// <summary>Internal Acessors for PublishedDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryArtifactPublishingProfileBaseInternal.PublishedDate { get => this._publishedDate; set { {_publishedDate = value;} } }

        /// <summary>Backing field for <see cref="PublishedDate" /> property.</summary>
        private global::System.DateTime? _publishedDate;

        /// <summary>The timestamp for when the gallery image version is published.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public global::System.DateTime? PublishedDate { get => this._publishedDate; }

        /// <summary>Backing field for <see cref="ReplicaCount" /> property.</summary>
        private int? _replicaCount;

        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property would take effect for a region when
        /// regionalReplicaCount is not specified. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public int? ReplicaCount { get => this._replicaCount; set => this._replicaCount = value; }

        /// <summary>Backing field for <see cref="ReplicationMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode? _replicationMode;

        /// <summary>
        /// Optional parameter which specifies the mode to be used for replication. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode? ReplicationMode { get => this._replicationMode; set => this._replicationMode = value; }

        /// <summary>Backing field for <see cref="StorageAccountType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? _storageAccountType;

        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get => this._storageAccountType; set => this._storageAccountType = value; }

        /// <summary>Backing field for <see cref="TargetExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[] _targetExtendedLocation;

        /// <summary>
        /// The target extended locations where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[] TargetExtendedLocation { get => this._targetExtendedLocation; set => this._targetExtendedLocation = value; }

        /// <summary>Backing field for <see cref="TargetRegion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[] _targetRegion;

        /// <summary>
        /// The target regions where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[] TargetRegion { get => this._targetRegion; set => this._targetRegion = value; }

        /// <summary>Creates an new <see cref="GalleryArtifactPublishingProfileBase" /> instance.</summary>
        public GalleryArtifactPublishingProfileBase()
        {

        }
    }
    /// Describes the basic gallery artifact publishing profile.
    public partial interface IGalleryArtifactPublishingProfileBase :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property
        /// is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable.",
        SerializedName = @"endOfLifeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndOfLifeDate { get; set; }
        /// <summary>
        /// If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version.",
        SerializedName = @"excludeFromLatest",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExcludeFromLatest { get; set; }
        /// <summary>The timestamp for when the gallery image version is published.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp for when the gallery image version is published.",
        SerializedName = @"publishedDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PublishedDate { get;  }
        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property would take effect for a region when
        /// regionalReplicaCount is not specified. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable.",
        SerializedName = @"replicaCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ReplicaCount { get; set; }
        /// <summary>
        /// Optional parameter which specifies the mode to be used for replication. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional parameter which specifies the mode to be used for replication. This property is not updatable.",
        SerializedName = @"replicationMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode? ReplicationMode { get; set; }
        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the storage account type to be used to store the image. This property is not updatable.",
        SerializedName = @"storageAccountType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get; set; }
        /// <summary>
        /// The target extended locations where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target extended locations where the Image Version is going to be replicated to. This property is updatable.",
        SerializedName = @"targetExtendedLocations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[] TargetExtendedLocation { get; set; }
        /// <summary>
        /// The target regions where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target regions where the Image Version is going to be replicated to. This property is updatable.",
        SerializedName = @"targetRegions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[] TargetRegion { get; set; }

    }
    /// Describes the basic gallery artifact publishing profile.
    internal partial interface IGalleryArtifactPublishingProfileBaseInternal

    {
        /// <summary>
        /// The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property
        /// is updatable.
        /// </summary>
        global::System.DateTime? EndOfLifeDate { get; set; }
        /// <summary>
        /// If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version.
        /// </summary>
        bool? ExcludeFromLatest { get; set; }
        /// <summary>The timestamp for when the gallery image version is published.</summary>
        global::System.DateTime? PublishedDate { get; set; }
        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property would take effect for a region when
        /// regionalReplicaCount is not specified. This property is updatable.
        /// </summary>
        int? ReplicaCount { get; set; }
        /// <summary>
        /// Optional parameter which specifies the mode to be used for replication. This property is not updatable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode? ReplicationMode { get; set; }
        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get; set; }
        /// <summary>
        /// The target extended locations where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryTargetExtendedLocation[] TargetExtendedLocation { get; set; }
        /// <summary>
        /// The target regions where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ITargetRegion[] TargetRegion { get; set; }

    }
}