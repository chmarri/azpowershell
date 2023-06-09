// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>Alert category</summary>
    public partial struct AlertCategory :
        System.IEquatable<AlertCategory>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory Billing = @"Billing";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory Cost = @"Cost";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory System1 = @"System";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory Usage = @"Usage";

        /// <summary>the value for an instance of the <see cref="AlertCategory" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AlertCategory"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AlertCategory(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AlertCategory</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertCategory" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AlertCategory(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AlertCategory</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AlertCategory (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AlertCategory && Equals((AlertCategory)obj);
        }

        /// <summary>Returns hashCode for enum AlertCategory</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AlertCategory</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AlertCategory</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertCategory" />.</param>

        public static implicit operator AlertCategory(string value)
        {
            return new AlertCategory(value);
        }

        /// <summary>Implicit operator to convert AlertCategory to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AlertCategory" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AlertCategory</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AlertCategory</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertCategory e2)
        {
            return e2.Equals(e1);
        }
    }
}