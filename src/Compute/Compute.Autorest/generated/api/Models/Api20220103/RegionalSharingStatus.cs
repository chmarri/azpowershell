// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Gallery regional sharing status</summary>
    public partial class RegionalSharingStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalSharingStatus,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalSharingStatusInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        /// <summary>Details of gallery regional sharing failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalSharingStatusInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>Region name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState? _state;

        /// <summary>Gallery sharing state in current region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState? State { get => this._state; }

        /// <summary>Creates an new <see cref="RegionalSharingStatus" /> instance.</summary>
        public RegionalSharingStatus()
        {

        }
    }
    /// Gallery regional sharing status
    public partial interface IRegionalSharingStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>Details of gallery regional sharing failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details of gallery regional sharing failure.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get; set; }
        /// <summary>Region name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Region name",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Gallery sharing state in current region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gallery sharing state in current region",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState? State { get;  }

    }
    /// Gallery regional sharing status
    internal partial interface IRegionalSharingStatusInternal

    {
        /// <summary>Details of gallery regional sharing failure.</summary>
        string Detail { get; set; }
        /// <summary>Region name</summary>
        string Region { get; set; }
        /// <summary>Gallery sharing state in current region</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.SharingState? State { get; set; }

    }
}