// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Valid values are Regular domain: Azure will charge the full price of domain registration, SoftDeleted: Purchasing this
    /// domain will simply restore it and this operation will not cost anything.
    /// </summary>
    public partial struct DomainType :
        System.IEquatable<DomainType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType Regular = @"Regular";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType SoftDeleted = @"SoftDeleted";

        /// <summary>the value for an instance of the <see cref="DomainType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DomainType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DomainType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DomainType(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DomainType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DomainType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DomainType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DomainType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DomainType && Equals((DomainType)obj);
        }

        /// <summary>Returns hashCode for enum DomainType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DomainType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DomainType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DomainType" />.</param>

        public static implicit operator DomainType(string value)
        {
            return new DomainType(value);
        }

        /// <summary>Implicit operator to convert DomainType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DomainType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DomainType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DomainType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DomainType e2)
        {
            return e2.Equals(e1);
        }
    }
}