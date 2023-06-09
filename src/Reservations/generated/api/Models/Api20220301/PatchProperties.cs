// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class PatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppliedScope" /> property.</summary>
        private string[] _appliedScope;

        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string[] AppliedScope { get => this._appliedScope; set => this._appliedScope = value; }

        /// <summary>Backing field for <see cref="AppliedScopeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? _appliedScopeType;

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get => this._appliedScopeType; set => this._appliedScopeType = value; }

        /// <summary>Backing field for <see cref="InstanceFlexibility" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? _instanceFlexibility;

        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? InstanceFlexibility { get => this._instanceFlexibility; set => this._instanceFlexibility = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the Reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Renew" /> property.</summary>
        private bool? _renew;

        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public bool? Renew { get => this._renew; set => this._renew = value; }

        /// <summary>Backing field for <see cref="RenewProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesRenewProperties _renewProperty;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesRenewProperties RenewProperty { get => (this._renewProperty = this._renewProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PatchPropertiesRenewProperties()); set => this._renewProperty = value; }

        /// <summary>Creates an new <see cref="PatchProperties" /> instance.</summary>
        public PatchProperties()
        {

        }
    }
    public partial interface IPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared.",
        SerializedName = @"appliedScopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] AppliedScope { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type.",
        SerializedName = @"instanceFlexibility",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? InstanceFlexibility { get; set; }
        /// <summary>Name of the Reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Reservation",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new reservation on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Renew { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"renewProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesRenewProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesRenewProperties RenewProperty { get; set; }

    }
    internal partial interface IPatchPropertiesInternal

    {
        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared.
        /// </summary>
        string[] AppliedScope { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? InstanceFlexibility { get; set; }
        /// <summary>Name of the Reservation</summary>
        string Name { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        bool? Renew { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPatchPropertiesRenewProperties RenewProperty { get; set; }

    }
}