// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The provisioning state</summary>
    public partial struct WorkloadNetworkVMGroupProvisioningState :
        System.IEquatable<WorkloadNetworkVMGroupProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState Building = @"Building";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="WorkloadNetworkVMGroupProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WorkloadNetworkVMGroupProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkVMGroupProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkloadNetworkVMGroupProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkloadNetworkVMGroupProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type WorkloadNetworkVMGroupProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkloadNetworkVMGroupProvisioningState && Equals((WorkloadNetworkVMGroupProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum WorkloadNetworkVMGroupProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkloadNetworkVMGroupProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkloadNetworkVMGroupProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkloadNetworkVMGroupProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WorkloadNetworkVMGroupProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkVMGroupProvisioningState" />.</param>

        public static implicit operator WorkloadNetworkVMGroupProvisioningState(string value)
        {
            return new WorkloadNetworkVMGroupProvisioningState(value);
        }

        /// <summary>Implicit operator to convert WorkloadNetworkVMGroupProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkloadNetworkVMGroupProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkloadNetworkVMGroupProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkloadNetworkVMGroupProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkVMGroupProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}