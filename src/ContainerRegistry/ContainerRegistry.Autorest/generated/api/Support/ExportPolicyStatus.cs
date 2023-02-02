// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The value that indicates whether the policy is enabled or not.</summary>
    public partial struct ExportPolicyStatus :
        System.IEquatable<ExportPolicyStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus Disabled = @"disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus Enabled = @"enabled";

        /// <summary>the value for an instance of the <see cref="ExportPolicyStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ExportPolicyStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExportPolicyStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ExportPolicyStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ExportPolicyStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ExportPolicyStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ExportPolicyStatus && Equals((ExportPolicyStatus)obj);
        }

        /// <summary>Creates an instance of the <see cref="ExportPolicyStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ExportPolicyStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ExportPolicyStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ExportPolicyStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ExportPolicyStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExportPolicyStatus" />.</param>

        public static implicit operator ExportPolicyStatus(string value)
        {
            return new ExportPolicyStatus(value);
        }

        /// <summary>Implicit operator to convert ExportPolicyStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ExportPolicyStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ExportPolicyStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ExportPolicyStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ExportPolicyStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}