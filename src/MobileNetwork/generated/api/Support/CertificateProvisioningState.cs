// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support
{

    /// <summary>The certificate's provisioning state</summary>
    public partial struct CertificateProvisioningState :
        System.IEquatable<CertificateProvisioningState>
    {
        /// <summary>The certificate failed to be provisioned. The "reason" property explains why.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState Failed = @"Failed";

        /// <summary>The certificate has not been provisioned.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState NotProvisioned = @"NotProvisioned";

        /// <summary>The certificate has been provisioned.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState Provisioned = @"Provisioned";

        /// <summary>
        /// the value for an instance of the <see cref="CertificateProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="CertificateProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CertificateProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to CertificateProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CertificateProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CertificateProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type CertificateProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CertificateProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CertificateProvisioningState && Equals((CertificateProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum CertificateProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CertificateProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CertificateProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CertificateProvisioningState" />.</param>

        public static implicit operator CertificateProvisioningState(string value)
        {
            return new CertificateProvisioningState(value);
        }

        /// <summary>Implicit operator to convert CertificateProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CertificateProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CertificateProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CertificateProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CertificateProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}