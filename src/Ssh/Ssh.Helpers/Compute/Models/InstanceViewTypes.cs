// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InstanceViewTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstanceViewTypes
    {
        [EnumMember(Value = "instanceView")]
        InstanceView,
        [EnumMember(Value = "userData")]
        UserData
    }
    internal static class InstanceViewTypesEnumExtension
    {
        internal static string ToSerializedValue(this InstanceViewTypes? value)
        {
            return value == null ? null : ((InstanceViewTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InstanceViewTypes value)
        {
            switch( value )
            {
                case InstanceViewTypes.InstanceView:
                    return "instanceView";
                case InstanceViewTypes.UserData:
                    return "userData";
            }
            return null;
        }

        internal static InstanceViewTypes? ParseInstanceViewTypes(this string value)
        {
            switch( value )
            {
                case "instanceView":
                    return InstanceViewTypes.InstanceView;
                case "userData":
                    return InstanceViewTypes.UserData;
            }
            return null;
        }
    }
}
