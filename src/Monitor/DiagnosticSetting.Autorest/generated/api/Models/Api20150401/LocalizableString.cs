// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;

    /// <summary>The localizable string class.</summary>
    public partial class LocalizableString :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.ILocalizableString,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.ILocalizableStringInternal
    {

        /// <summary>Backing field for <see cref="LocalizedValue" /> property.</summary>
        private string _localizedValue;

        /// <summary>the locale specific value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string LocalizedValue { get => this._localizedValue; set => this._localizedValue = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>the invariant value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LocalizableString" /> instance.</summary>
        public LocalizableString()
        {

        }
    }
    /// The localizable string class.
    public partial interface ILocalizableString :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IJsonSerializable
    {
        /// <summary>the locale specific value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the locale specific value.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string LocalizedValue { get; set; }
        /// <summary>the invariant value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"the invariant value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The localizable string class.
    internal partial interface ILocalizableStringInternal

    {
        /// <summary>the locale specific value.</summary>
        string LocalizedValue { get; set; }
        /// <summary>the invariant value.</summary>
        string Value { get; set; }

    }
}