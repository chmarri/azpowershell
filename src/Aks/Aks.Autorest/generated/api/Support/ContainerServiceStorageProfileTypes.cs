// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>
    /// Storage profile specifies what kind of storage used. Choose from StorageAccount and ManagedDisks. Leave it empty, we will
    /// choose for you based on the orchestrator choice.
    /// </summary>
    public partial struct ContainerServiceStorageProfileTypes :
        System.IEquatable<ContainerServiceStorageProfileTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes ManagedDisks = @"ManagedDisks";

        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes StorageAccount = @"StorageAccount";

        /// <summary>
        /// the value for an instance of the <see cref="ContainerServiceStorageProfileTypes" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="ContainerServiceStorageProfileTypes"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ContainerServiceStorageProfileTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ContainerServiceStorageProfileTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ContainerServiceStorageProfileTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ContainerServiceStorageProfileTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ContainerServiceStorageProfileTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ContainerServiceStorageProfileTypes (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ContainerServiceStorageProfileTypes && Equals((ContainerServiceStorageProfileTypes)obj);
        }

        /// <summary>Returns hashCode for enum ContainerServiceStorageProfileTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ContainerServiceStorageProfileTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ContainerServiceStorageProfileTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ContainerServiceStorageProfileTypes" />.</param>

        public static implicit operator ContainerServiceStorageProfileTypes(string value)
        {
            return new ContainerServiceStorageProfileTypes(value);
        }

        /// <summary>Implicit operator to convert ContainerServiceStorageProfileTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ContainerServiceStorageProfileTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ContainerServiceStorageProfileTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ContainerServiceStorageProfileTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.ContainerServiceStorageProfileTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}