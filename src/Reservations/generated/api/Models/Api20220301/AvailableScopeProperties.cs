// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class AvailableScopeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IAvailableScopeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IAvailableScopePropertiesInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopeProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IAvailableScopePropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.SubscriptionScopeProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopeProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.SubscriptionScopeProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IScopeProperties[] Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopePropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopePropertiesInternal)Property).Scope = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="AvailableScopeProperties" /> instance.</summary>
        public AvailableScopeProperties()
        {

        }
    }
    public partial interface IAvailableScopeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"scopes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IScopeProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IScopeProperties[] Scope { get; set; }

    }
    internal partial interface IAvailableScopePropertiesInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ISubscriptionScopeProperties Property { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IScopeProperties[] Scope { get; set; }

    }
}