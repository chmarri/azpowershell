// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
    public partial struct GlobalReachConnectionProvisioningState :
        System.IEquatable<GlobalReachConnectionProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="GlobalReachConnectionProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to GlobalReachConnectionProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GlobalReachConnectionProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new GlobalReachConnectionProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type GlobalReachConnectionProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type GlobalReachConnectionProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is GlobalReachConnectionProvisioningState && Equals((GlobalReachConnectionProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum GlobalReachConnectionProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="GlobalReachConnectionProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private GlobalReachConnectionProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for GlobalReachConnectionProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to GlobalReachConnectionProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GlobalReachConnectionProvisioningState" />.</param>

        public static implicit operator GlobalReachConnectionProvisioningState(string value)
        {
            return new GlobalReachConnectionProvisioningState(value);
        }

        /// <summary>Implicit operator to convert GlobalReachConnectionProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="GlobalReachConnectionProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum GlobalReachConnectionProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum GlobalReachConnectionProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.GlobalReachConnectionProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}