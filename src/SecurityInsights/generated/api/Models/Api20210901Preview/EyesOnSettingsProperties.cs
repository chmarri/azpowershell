// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>EyesOn property bag.</summary>
    public partial class EyesOnSettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEyesOnSettingsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEyesOnSettingsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="IsEnabled" /> property.</summary>
        private bool? _isEnabled;

        /// <summary>Determines whether the setting is enable or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? IsEnabled { get => this._isEnabled; }

        /// <summary>Internal Acessors for IsEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEyesOnSettingsPropertiesInternal.IsEnabled { get => this._isEnabled; set { {_isEnabled = value;} } }

        /// <summary>Creates an new <see cref="EyesOnSettingsProperties" /> instance.</summary>
        public EyesOnSettingsProperties()
        {

        }
    }
    /// EyesOn property bag.
    public partial interface IEyesOnSettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Determines whether the setting is enable or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Determines whether the setting is enable or disabled.",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEnabled { get;  }

    }
    /// EyesOn property bag.
    internal partial interface IEyesOnSettingsPropertiesInternal

    {
        /// <summary>Determines whether the setting is enable or disabled.</summary>
        bool? IsEnabled { get; set; }

    }
}