// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    /// <summary>type of datastore; Operational/Vault/Archive</summary>
    public partial struct DataStoreTypes :
        System.IEquatable<DataStoreTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes ArchiveStore = @"ArchiveStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes OperationalStore = @"OperationalStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes VaultStore = @"VaultStore";

        /// <summary>the value for an instance of the <see cref="DataStoreTypes" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DataStoreTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataStoreTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DataStoreTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DataStoreTypes"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DataStoreTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DataStoreTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DataStoreTypes (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DataStoreTypes && Equals((DataStoreTypes)obj);
        }

        /// <summary>Returns hashCode for enum DataStoreTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DataStoreTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DataStoreTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataStoreTypes" />.</param>

        public static implicit operator DataStoreTypes(string value)
        {
            return new DataStoreTypes(value);
        }

        /// <summary>Implicit operator to convert DataStoreTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DataStoreTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DataStoreTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DataStoreTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}