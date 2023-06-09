// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support
{

    /// <summary>
    /// the metric statistic type. How the metrics from multiple instances are combined.
    /// </summary>
    public partial struct MetricStatisticType :
        System.IEquatable<MetricStatisticType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType Average = @"Average";

        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType Count = @"Count";

        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType Max = @"Max";

        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType Min = @"Min";

        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType Sum = @"Sum";

        /// <summary>the value for an instance of the <see cref="MetricStatisticType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MetricStatisticType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricStatisticType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MetricStatisticType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MetricStatisticType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MetricStatisticType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MetricStatisticType && Equals((MetricStatisticType)obj);
        }

        /// <summary>Returns hashCode for enum MetricStatisticType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MetricStatisticType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MetricStatisticType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MetricStatisticType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MetricStatisticType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricStatisticType" />.</param>

        public static implicit operator MetricStatisticType(string value)
        {
            return new MetricStatisticType(value);
        }

        /// <summary>Implicit operator to convert MetricStatisticType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MetricStatisticType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MetricStatisticType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e1, Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MetricStatisticType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e1, Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.MetricStatisticType e2)
        {
            return e2.Equals(e1);
        }
    }
}