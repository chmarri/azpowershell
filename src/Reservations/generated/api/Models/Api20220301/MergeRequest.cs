// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class MergeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeRequestInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.MergeProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.MergeProperties()); set => this._property = value; }

        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string[] Source { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergePropertiesInternal)Property).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergePropertiesInternal)Property).Source = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="MergeRequest" /> instance.</summary>
        public MergeRequest()
        {

        }
    }
    public partial interface IMergeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}",
        SerializedName = @"sources",
        PossibleTypes = new [] { typeof(string) })]
        string[] Source { get; set; }

    }
    internal partial interface IMergeRequestInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IMergeProperties Property { get; set; }
        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        string[] Source { get; set; }

    }
}