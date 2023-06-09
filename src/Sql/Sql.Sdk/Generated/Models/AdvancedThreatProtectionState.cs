// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AdvancedThreatProtectionState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdvancedThreatProtectionState
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class AdvancedThreatProtectionStateEnumExtension
    {
        internal static string ToSerializedValue(this AdvancedThreatProtectionState? value)
        {
            return value == null ? null : ((AdvancedThreatProtectionState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AdvancedThreatProtectionState value)
        {
            switch( value )
            {
                case AdvancedThreatProtectionState.New:
                    return "New";
                case AdvancedThreatProtectionState.Enabled:
                    return "Enabled";
                case AdvancedThreatProtectionState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static AdvancedThreatProtectionState? ParseAdvancedThreatProtectionState(this string value)
        {
            switch( value )
            {
                case "New":
                    return AdvancedThreatProtectionState.New;
                case "Enabled":
                    return AdvancedThreatProtectionState.Enabled;
                case "Disabled":
                    return AdvancedThreatProtectionState.Disabled;
            }
            return null;
        }
    }
}
