// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>Enum to determine the type of data.</summary>
    public partial struct DataType :
        System.IEquatable<DataType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType Mltable = @"mltable";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType UriFile = @"uri_file";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType UriFolder = @"uri_folder";

        /// <summary>the value for an instance of the <see cref="DataType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DataType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DataType(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DataType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DataType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DataType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DataType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DataType && Equals((DataType)obj);
        }

        /// <summary>Returns hashCode for enum DataType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DataType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DataType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataType" />.</param>

        public static implicit operator DataType(string value)
        {
            return new DataType(value);
        }

        /// <summary>Implicit operator to convert DataType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DataType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DataType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DataType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType e2)
        {
            return e2.Equals(e1);
        }
    }
}