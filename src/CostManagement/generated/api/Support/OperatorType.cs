// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The operator to use for comparison.</summary>
    public partial struct OperatorType :
        System.IEquatable<OperatorType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType Contains = @"Contains";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType In = @"In";

        /// <summary>the value for an instance of the <see cref="OperatorType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OperatorType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatorType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OperatorType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OperatorType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OperatorType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OperatorType && Equals((OperatorType)obj);
        }

        /// <summary>Returns hashCode for enum OperatorType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OperatorType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OperatorType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OperatorType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OperatorType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatorType" />.</param>

        public static implicit operator OperatorType(string value)
        {
            return new OperatorType(value);
        }

        /// <summary>Implicit operator to convert OperatorType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OperatorType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OperatorType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OperatorType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.OperatorType e2)
        {
            return e2.Equals(e1);
        }
    }
}