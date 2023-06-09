// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Consent property bag.</summary>
    public partial class OfficeConsentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IOfficeConsentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IOfficeConsentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ConsentId" /> property.</summary>
        private string _consentId;

        /// <summary>Help to easily cascade among the data layers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ConsentId { get => this._consentId; set => this._consentId = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenantId of the Office365 with the consent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="OfficeConsentProperties" /> instance.</summary>
        public OfficeConsentProperties()
        {

        }
    }
    /// Consent property bag.
    public partial interface IOfficeConsentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Help to easily cascade among the data layers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Help to easily cascade among the data layers.",
        SerializedName = @"consentId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsentId { get; set; }
        /// <summary>The tenantId of the Office365 with the consent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenantId of the Office365 with the consent.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// Consent property bag.
    internal partial interface IOfficeConsentPropertiesInternal

    {
        /// <summary>Help to easily cascade among the data layers.</summary>
        string ConsentId { get; set; }
        /// <summary>The tenantId of the Office365 with the consent.</summary>
        string TenantId { get; set; }

    }
}