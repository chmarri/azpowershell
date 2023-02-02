// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The current status of the run.</summary>
    public partial struct RunStatus :
        System.IEquatable<RunStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Error = @"Error";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Queued = @"Queued";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Running = @"Running";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Started = @"Started";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus Timeout = @"Timeout";

        /// <summary>the value for an instance of the <see cref="RunStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RunStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RunStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RunStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RunStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RunStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RunStatus && Equals((RunStatus)obj);
        }

        /// <summary>Returns hashCode for enum RunStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RunStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RunStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RunStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RunStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RunStatus" />.</param>

        public static implicit operator RunStatus(string value)
        {
            return new RunStatus(value);
        }

        /// <summary>Implicit operator to convert RunStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RunStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RunStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RunStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RunStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}