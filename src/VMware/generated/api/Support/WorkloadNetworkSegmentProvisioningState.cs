// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The provisioning state</summary>
    public partial struct WorkloadNetworkSegmentProvisioningState :
        System.IEquatable<WorkloadNetworkSegmentProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState Building = @"Building";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="WorkloadNetworkSegmentProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WorkloadNetworkSegmentProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkSegmentProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkloadNetworkSegmentProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkloadNetworkSegmentProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type WorkloadNetworkSegmentProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkloadNetworkSegmentProvisioningState && Equals((WorkloadNetworkSegmentProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum WorkloadNetworkSegmentProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkloadNetworkSegmentProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkloadNetworkSegmentProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkloadNetworkSegmentProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WorkloadNetworkSegmentProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkSegmentProvisioningState" />.</param>

        public static implicit operator WorkloadNetworkSegmentProvisioningState(string value)
        {
            return new WorkloadNetworkSegmentProvisioningState(value);
        }

        /// <summary>Implicit operator to convert WorkloadNetworkSegmentProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkloadNetworkSegmentProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkloadNetworkSegmentProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkloadNetworkSegmentProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkSegmentProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}