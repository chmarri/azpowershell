// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct ResourceNotRenewableReason :
        System.IEquatable<ResourceNotRenewableReason>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason ExpirationNotInRenewalTimeRange = @"ExpirationNotInRenewalTimeRange";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason RegistrationStatusNotSupportedForRenewal = @"RegistrationStatusNotSupportedForRenewal";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason SubscriptionNotActive = @"SubscriptionNotActive";

        /// <summary>
        /// the value for an instance of the <see cref="ResourceNotRenewableReason" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceNotRenewableReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceNotRenewableReason" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResourceNotRenewableReason(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceNotRenewableReason</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceNotRenewableReason (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceNotRenewableReason && Equals((ResourceNotRenewableReason)obj);
        }

        /// <summary>Returns hashCode for enum ResourceNotRenewableReason</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResourceNotRenewableReason"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceNotRenewableReason(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceNotRenewableReason</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceNotRenewableReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceNotRenewableReason" />.</param>

        public static implicit operator ResourceNotRenewableReason(string value)
        {
            return new ResourceNotRenewableReason(value);
        }

        /// <summary>Implicit operator to convert ResourceNotRenewableReason to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceNotRenewableReason" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceNotRenewableReason</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceNotRenewableReason</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResourceNotRenewableReason e2)
        {
            return e2.Equals(e1);
        }
    }
}