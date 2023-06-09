// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support
{

    /// <summary>Indicates whether Azure Hybrid Benefit is opted in</summary>
    public partial struct AzureHybridBenefit :
        System.IEquatable<AzureHybridBenefit>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit False = @"False";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit NotApplicable = @"NotApplicable";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit True = @"True";

        /// <summary>the value for an instance of the <see cref="AzureHybridBenefit" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AzureHybridBenefit"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AzureHybridBenefit(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AzureHybridBenefit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureHybridBenefit" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AzureHybridBenefit(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AzureHybridBenefit</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AzureHybridBenefit (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AzureHybridBenefit && Equals((AzureHybridBenefit)obj);
        }

        /// <summary>Returns hashCode for enum AzureHybridBenefit</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AzureHybridBenefit</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AzureHybridBenefit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureHybridBenefit" />.</param>

        public static implicit operator AzureHybridBenefit(string value)
        {
            return new AzureHybridBenefit(value);
        }

        /// <summary>Implicit operator to convert AzureHybridBenefit to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AzureHybridBenefit" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AzureHybridBenefit</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AzureHybridBenefit</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit e2)
        {
            return e2.Equals(e1);
        }
    }
}