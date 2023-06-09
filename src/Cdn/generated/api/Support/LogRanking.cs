// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    public partial struct LogRanking :
        System.IEquatable<LogRanking>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking Browser = @"browser";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking CountryOrRegion = @"countryOrRegion";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking Referrer = @"referrer";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking Url = @"url";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking UserAgent = @"userAgent";

        /// <summary>the value for an instance of the <see cref="LogRanking" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LogRanking</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LogRanking" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LogRanking(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LogRanking</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LogRanking (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LogRanking && Equals((LogRanking)obj);
        }

        /// <summary>Returns hashCode for enum LogRanking</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LogRanking"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LogRanking(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LogRanking</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LogRanking</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LogRanking" />.</param>

        public static implicit operator LogRanking(string value)
        {
            return new LogRanking(value);
        }

        /// <summary>Implicit operator to convert LogRanking to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LogRanking" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LogRanking</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LogRanking</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LogRanking e2)
        {
            return e2.Equals(e1);
        }
    }
}