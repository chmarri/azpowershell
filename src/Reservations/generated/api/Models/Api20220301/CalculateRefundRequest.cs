// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class CalculateRefundRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified identifier of the reservation order being returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculateRefundRequestProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReservationToReturn</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturn Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestInternal.ReservationToReturn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturn = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculateRefundRequestProperties()); set => this._property = value; }

        /// <summary>Quantity to be returned. Must be greater than zero.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public int? ReservationToReturnQuantity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturnQuantity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturnQuantity = value ?? default(int); }

        /// <summary>Fully qualified identifier of the Reservation being returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string ReservationToReturnReservationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturnReservationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).ReservationToReturnReservationId = value ?? null; }

        /// <summary>The scope of the refund, e.g. Reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestPropertiesInternal)Property).Scope = value ?? null; }

        /// <summary>Creates an new <see cref="CalculateRefundRequest" /> instance.</summary>
        public CalculateRefundRequest()
        {

        }
    }
    public partial interface ICalculateRefundRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified identifier of the reservation order being returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified identifier of the reservation order being returned",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Quantity to be returned. Must be greater than zero.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Quantity to be returned. Must be greater than zero.",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(int) })]
        int? ReservationToReturnQuantity { get; set; }
        /// <summary>Fully qualified identifier of the Reservation being returned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified identifier of the Reservation being returned",
        SerializedName = @"reservationId",
        PossibleTypes = new [] { typeof(string) })]
        string ReservationToReturnReservationId { get; set; }
        /// <summary>The scope of the refund, e.g. Reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope of the refund, e.g. Reservation",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }

    }
    internal partial interface ICalculateRefundRequestInternal

    {
        /// <summary>Fully qualified identifier of the reservation order being returned</summary>
        string Id { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculateRefundRequestProperties Property { get; set; }
        /// <summary>Reservation to return</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IReservationToReturn ReservationToReturn { get; set; }
        /// <summary>Quantity to be returned. Must be greater than zero.</summary>
        int? ReservationToReturnQuantity { get; set; }
        /// <summary>Fully qualified identifier of the Reservation being returned</summary>
        string ReservationToReturnReservationId { get; set; }
        /// <summary>The scope of the refund, e.g. Reservation</summary>
        string Scope { get; set; }

    }
}