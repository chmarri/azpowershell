// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Resource status of the custom domain.</summary>
    public partial struct CustomDomainResourceState :
        System.IEquatable<CustomDomainResourceState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState Active = @"Active";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState Deleting = @"Deleting";

        /// <summary>the value for an instance of the <see cref="CustomDomainResourceState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to CustomDomainResourceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CustomDomainResourceState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CustomDomainResourceState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="CustomDomainResourceState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CustomDomainResourceState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type CustomDomainResourceState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CustomDomainResourceState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CustomDomainResourceState && Equals((CustomDomainResourceState)obj);
        }

        /// <summary>Returns hashCode for enum CustomDomainResourceState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CustomDomainResourceState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CustomDomainResourceState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CustomDomainResourceState" />.</param>

        public static implicit operator CustomDomainResourceState(string value)
        {
            return new CustomDomainResourceState(value);
        }

        /// <summary>Implicit operator to convert CustomDomainResourceState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CustomDomainResourceState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CustomDomainResourceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CustomDomainResourceState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomDomainResourceState e2)
        {
            return e2.Equals(e1);
        }
    }
}