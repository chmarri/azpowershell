// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FailoverType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FailoverType
    {
        [EnumMember(Value = "Planned")]
        Planned
    }
    internal static class FailoverTypeEnumExtension
    {
        internal static string ToSerializedValue(this FailoverType? value)
        {
            return value == null ? null : ((FailoverType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FailoverType value)
        {
            switch( value )
            {
                case FailoverType.Planned:
                    return "Planned";
            }
            return null;
        }

        internal static FailoverType? ParseFailoverType(this string value)
        {
            switch( value )
            {
                case "Planned":
                    return FailoverType.Planned;
            }
            return null;
        }
    }
}
