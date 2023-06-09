// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support
{

    /// <summary>The compliance state of the configuration.</summary>
    public partial struct ComplianceStateType :
        System.IEquatable<ComplianceStateType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType Compliant = @"Compliant";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType Installed = @"Installed";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType Noncompliant = @"Noncompliant";

        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType Pending = @"Pending";

        /// <summary>the value for an instance of the <see cref="ComplianceStateType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ComplianceStateType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ComplianceStateType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ComplianceStateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ComplianceStateType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ComplianceStateType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ComplianceStateType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ComplianceStateType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ComplianceStateType && Equals((ComplianceStateType)obj);
        }

        /// <summary>Returns hashCode for enum ComplianceStateType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ComplianceStateType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ComplianceStateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ComplianceStateType" />.</param>

        public static implicit operator ComplianceStateType(string value)
        {
            return new ComplianceStateType(value);
        }

        /// <summary>Implicit operator to convert ComplianceStateType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ComplianceStateType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ComplianceStateType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e1, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ComplianceStateType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e1, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ComplianceStateType e2)
        {
            return e2.Equals(e1);
        }
    }
}