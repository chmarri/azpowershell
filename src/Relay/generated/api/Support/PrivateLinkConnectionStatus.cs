// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Relay.Support
{

    /// <summary>Status of the connection.</summary>
    public partial struct PrivateLinkConnectionStatus :
        System.IEquatable<PrivateLinkConnectionStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus Approved = @"Approved";

        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus Rejected = @"Rejected";

        /// <summary>
        /// the value for an instance of the <see cref="PrivateLinkConnectionStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PrivateLinkConnectionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateLinkConnectionStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PrivateLinkConnectionStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PrivateLinkConnectionStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PrivateLinkConnectionStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PrivateLinkConnectionStatus && Equals((PrivateLinkConnectionStatus)obj);
        }

        /// <summary>Returns hashCode for enum PrivateLinkConnectionStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PrivateLinkConnectionStatus"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PrivateLinkConnectionStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PrivateLinkConnectionStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PrivateLinkConnectionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateLinkConnectionStatus" />.</param>

        public static implicit operator PrivateLinkConnectionStatus(string value)
        {
            return new PrivateLinkConnectionStatus(value);
        }

        /// <summary>Implicit operator to convert PrivateLinkConnectionStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PrivateLinkConnectionStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PrivateLinkConnectionStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PrivateLinkConnectionStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.PrivateLinkConnectionStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}