// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The provisioning state</summary>
    public partial struct PlacementPolicyProvisioningState :
        System.IEquatable<PlacementPolicyProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState Building = @"Building";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="PlacementPolicyProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PlacementPolicyProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PlacementPolicyProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PlacementPolicyProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PlacementPolicyProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PlacementPolicyProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PlacementPolicyProvisioningState && Equals((PlacementPolicyProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum PlacementPolicyProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PlacementPolicyProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PlacementPolicyProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PlacementPolicyProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PlacementPolicyProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PlacementPolicyProvisioningState" />.</param>

        public static implicit operator PlacementPolicyProvisioningState(string value)
        {
            return new PlacementPolicyProvisioningState(value);
        }

        /// <summary>Implicit operator to convert PlacementPolicyProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PlacementPolicyProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PlacementPolicyProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PlacementPolicyProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.PlacementPolicyProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}