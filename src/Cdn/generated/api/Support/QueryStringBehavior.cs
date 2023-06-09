// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Caching behavior for the requests</summary>
    public partial struct QueryStringBehavior :
        System.IEquatable<QueryStringBehavior>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior Exclude = @"Exclude";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior ExcludeAll = @"ExcludeAll";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior Include = @"Include";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior IncludeAll = @"IncludeAll";

        /// <summary>the value for an instance of the <see cref="QueryStringBehavior" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to QueryStringBehavior</summary>
        /// <param name="value">the value to convert to an instance of <see cref="QueryStringBehavior" />.</param>
        internal static object CreateFrom(object value)
        {
            return new QueryStringBehavior(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type QueryStringBehavior</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type QueryStringBehavior (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is QueryStringBehavior && Equals((QueryStringBehavior)obj);
        }

        /// <summary>Returns hashCode for enum QueryStringBehavior</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="QueryStringBehavior"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private QueryStringBehavior(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for QueryStringBehavior</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to QueryStringBehavior</summary>
        /// <param name="value">the value to convert to an instance of <see cref="QueryStringBehavior" />.</param>

        public static implicit operator QueryStringBehavior(string value)
        {
            return new QueryStringBehavior(value);
        }

        /// <summary>Implicit operator to convert QueryStringBehavior to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="QueryStringBehavior" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum QueryStringBehavior</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum QueryStringBehavior</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior e2)
        {
            return e2.Equals(e1);
        }
    }
}