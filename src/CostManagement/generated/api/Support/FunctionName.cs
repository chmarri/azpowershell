// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The name of the column to aggregate.</summary>
    public partial struct FunctionName :
        System.IEquatable<FunctionName>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName Cost = @"Cost";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName CostUsd = @"CostUSD";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName PreTaxCost = @"PreTaxCost";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName PreTaxCostUsd = @"PreTaxCostUSD";

        /// <summary>the value for an instance of the <see cref="FunctionName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FunctionName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FunctionName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FunctionName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FunctionName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FunctionName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FunctionName && Equals((FunctionName)obj);
        }

        /// <summary>Creates an instance of the <see cref="FunctionName"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FunctionName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FunctionName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FunctionName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FunctionName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FunctionName" />.</param>

        public static implicit operator FunctionName(string value)
        {
            return new FunctionName(value);
        }

        /// <summary>Implicit operator to convert FunctionName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FunctionName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FunctionName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FunctionName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName e2)
        {
            return e2.Equals(e1);
        }
    }
}