// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support
{

    /// <summary>The current update status of OneAgent.</summary>
    public partial struct UpdateStatus :
        System.IEquatable<UpdateStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Incompatible = @"INCOMPATIBLE";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Outdated = @"OUTDATED";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Scheduled = @"SCHEDULED";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Suppressed = @"SUPPRESSED";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Unknown = @"UNKNOWN";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus Up2Date = @"UP2DATE";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus UpdateInProgress = @"UPDATE_IN_PROGRESS";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus UpdatePending = @"UPDATE_PENDING";

        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus UpdateProblem = @"UPDATE_PROBLEM";

        /// <summary>the value for an instance of the <see cref="UpdateStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UpdateStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UpdateStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UpdateStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UpdateStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UpdateStatus && Equals((UpdateStatus)obj);
        }

        /// <summary>Returns hashCode for enum UpdateStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UpdateStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UpdateStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UpdateStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UpdateStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateStatus" />.</param>

        public static implicit operator UpdateStatus(string value)
        {
            return new UpdateStatus(value);
        }

        /// <summary>Implicit operator to convert UpdateStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UpdateStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UpdateStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UpdateStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.UpdateStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}