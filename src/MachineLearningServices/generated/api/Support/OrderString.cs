// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    public partial struct OrderString :
        System.IEquatable<OrderString>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString CreatedAtAsc = @"CreatedAtAsc";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString CreatedAtDesc = @"CreatedAtDesc";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString UpdatedAtAsc = @"UpdatedAtAsc";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString UpdatedAtDesc = @"UpdatedAtDesc";

        /// <summary>the value for an instance of the <see cref="OrderString" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OrderString</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OrderString" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OrderString(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OrderString</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OrderString (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OrderString && Equals((OrderString)obj);
        }

        /// <summary>Returns hashCode for enum OrderString</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OrderString"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OrderString(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OrderString</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OrderString</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OrderString" />.</param>

        public static implicit operator OrderString(string value)
        {
            return new OrderString(value);
        }

        /// <summary>Implicit operator to convert OrderString to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OrderString" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OrderString</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OrderString</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OrderString e2)
        {
            return e2.Equals(e1);
        }
    }
}