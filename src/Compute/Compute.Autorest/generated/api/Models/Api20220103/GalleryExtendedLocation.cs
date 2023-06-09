// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>The name of the extended location.</summary>
    public partial class GalleryExtendedLocation :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryExtendedLocation,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryExtendedLocationInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryExtendedLocationType? _type;

        /// <summary>It is type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryExtendedLocationType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="GalleryExtendedLocation" /> instance.</summary>
        public GalleryExtendedLocation()
        {

        }
    }
    /// The name of the extended location.
    public partial interface IGalleryExtendedLocation :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>It is type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"It is type of the extended location.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryExtendedLocationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryExtendedLocationType? Type { get; set; }

    }
    /// The name of the extended location.
    internal partial interface IGalleryExtendedLocationInternal

    {
        string Name { get; set; }
        /// <summary>It is type of the extended location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryExtendedLocationType? Type { get; set; }

    }
}