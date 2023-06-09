// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Support
{

    /// <summary>Microsoft App Type for the bot</summary>
    public partial struct MsaAppType :
        System.IEquatable<MsaAppType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType MultiTenant = @"MultiTenant";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType SingleTenant = @"SingleTenant";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType UserAssignedMsi = @"UserAssignedMSI";

        /// <summary>the value for an instance of the <see cref="MsaAppType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MsaAppType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MsaAppType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MsaAppType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MsaAppType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MsaAppType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MsaAppType && Equals((MsaAppType)obj);
        }

        /// <summary>Returns hashCode for enum MsaAppType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MsaAppType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MsaAppType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MsaAppType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MsaAppType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MsaAppType" />.</param>

        public static implicit operator MsaAppType(string value)
        {
            return new MsaAppType(value);
        }

        /// <summary>Implicit operator to convert MsaAppType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MsaAppType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MsaAppType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MsaAppType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.MsaAppType e2)
        {
            return e2.Equals(e1);
        }
    }
}