// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>A list of private link resources</summary>
    public partial class PrivateLinkResourceListResultDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceListResultDescription,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceListResultDescriptionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription[] _value;

        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription[] Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="PrivateLinkResourceListResultDescription" /> instance.
        /// </summary>
        public PrivateLinkResourceListResultDescription()
        {

        }
    }
    /// A list of private link resources
    public partial interface IPrivateLinkResourceListResultDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription[] Value { get; set; }

    }
    /// A list of private link resources
    internal partial interface IPrivateLinkResourceListResultDescriptionInternal

    {
        /// <summary>Array of private link resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription[] Value { get; set; }

    }
}