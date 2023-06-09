// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>Response for Volume request.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.DoNotFormat]
    public partial class VolumeUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VolumeUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateProperties _property;

        /// <summary>Properties of Volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VolumeUpdateProperties()); set => this._property = value; }

        /// <summary>Volume size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? SizeGiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdatePropertiesInternal)Property).SizeGiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdatePropertiesInternal)Property).SizeGiB = value ?? default(long); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VolumeUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="VolumeUpdate" /> instance.</summary>
        public VolumeUpdate()
        {

        }
    }
    /// Response for Volume request.
    public partial interface IVolumeUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>Volume size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Volume size.",
        SerializedName = @"sizeGiB",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeGiB { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateTags Tag { get; set; }

    }
    /// Response for Volume request.
    internal partial interface IVolumeUpdateInternal

    {
        /// <summary>Properties of Volume.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateProperties Property { get; set; }
        /// <summary>Volume size.</summary>
        long? SizeGiB { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeUpdateTags Tag { get; set; }

    }
}