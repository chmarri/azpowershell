// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Status of the Key Vault secret.</summary>
    public partial struct KeyVaultSecretStatus :
        System.IEquatable<KeyVaultSecretStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus AzureServiceUnauthorizedToAccessKeyVault = @"AzureServiceUnauthorizedToAccessKeyVault";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus CertificateOrderFailed = @"CertificateOrderFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus ExternalPrivateKey = @"ExternalPrivateKey";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus Initialized = @"Initialized";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus KeyVaultDoesNotExist = @"KeyVaultDoesNotExist";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus KeyVaultSecretDoesNotExist = @"KeyVaultSecretDoesNotExist";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus OperationNotPermittedOnKeyVault = @"OperationNotPermittedOnKeyVault";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus UnknownError = @"UnknownError";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus WaitingOnCertificateOrder = @"WaitingOnCertificateOrder";

        /// <summary>the value for an instance of the <see cref="KeyVaultSecretStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to KeyVaultSecretStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyVaultSecretStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new KeyVaultSecretStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type KeyVaultSecretStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type KeyVaultSecretStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is KeyVaultSecretStatus && Equals((KeyVaultSecretStatus)obj);
        }

        /// <summary>Returns hashCode for enum KeyVaultSecretStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="KeyVaultSecretStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private KeyVaultSecretStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for KeyVaultSecretStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to KeyVaultSecretStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyVaultSecretStatus" />.</param>

        public static implicit operator KeyVaultSecretStatus(string value)
        {
            return new KeyVaultSecretStatus(value);
        }

        /// <summary>Implicit operator to convert KeyVaultSecretStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="KeyVaultSecretStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum KeyVaultSecretStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum KeyVaultSecretStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}