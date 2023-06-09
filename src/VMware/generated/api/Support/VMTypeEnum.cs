// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>Virtual machine type.</summary>
    public partial struct VMTypeEnum :
        System.IEquatable<VMTypeEnum>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum Edge = @"EDGE";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum Regular = @"REGULAR";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum Service = @"SERVICE";

        /// <summary>the value for an instance of the <see cref="VMTypeEnum" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to VMTypeEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VMTypeEnum" />.</param>
        internal static object CreateFrom(object value)
        {
            return new VMTypeEnum(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type VMTypeEnum</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type VMTypeEnum (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is VMTypeEnum && Equals((VMTypeEnum)obj);
        }

        /// <summary>Returns hashCode for enum VMTypeEnum</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for VMTypeEnum</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="VMTypeEnum"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private VMTypeEnum(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to VMTypeEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VMTypeEnum" />.</param>

        public static implicit operator VMTypeEnum(string value)
        {
            return new VMTypeEnum(value);
        }

        /// <summary>Implicit operator to convert VMTypeEnum to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="VMTypeEnum" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum VMTypeEnum</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum VMTypeEnum</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VMTypeEnum e2)
        {
            return e2.Equals(e1);
        }
    }
}