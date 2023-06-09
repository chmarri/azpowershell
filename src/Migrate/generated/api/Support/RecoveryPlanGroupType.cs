// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The group type.</summary>
    public partial struct RecoveryPlanGroupType :
        System.IEquatable<RecoveryPlanGroupType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType Boot = @"Boot";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType Failover = @"Failover";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType Shutdown = @"Shutdown";

        /// <summary>the value for an instance of the <see cref="RecoveryPlanGroupType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RecoveryPlanGroupType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPlanGroupType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RecoveryPlanGroupType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RecoveryPlanGroupType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RecoveryPlanGroupType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RecoveryPlanGroupType && Equals((RecoveryPlanGroupType)obj);
        }

        /// <summary>Returns hashCode for enum RecoveryPlanGroupType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RecoveryPlanGroupType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RecoveryPlanGroupType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RecoveryPlanGroupType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RecoveryPlanGroupType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPlanGroupType" />.</param>

        public static implicit operator RecoveryPlanGroupType(string value)
        {
            return new RecoveryPlanGroupType(value);
        }

        /// <summary>Implicit operator to convert RecoveryPlanGroupType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RecoveryPlanGroupType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RecoveryPlanGroupType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RecoveryPlanGroupType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanGroupType e2)
        {
            return e2.Equals(e1);
        }
    }
}