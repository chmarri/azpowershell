// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support
{

    /// <summary>State of user session.</summary>
    public partial struct SessionState :
        System.IEquatable<SessionState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState Active = @"Active";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState LogOff = @"LogOff";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState UserProfileDiskMounted = @"UserProfileDiskMounted";

        /// <summary>the value for an instance of the <see cref="SessionState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SessionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SessionState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SessionState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SessionState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SessionState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SessionState && Equals((SessionState)obj);
        }

        /// <summary>Returns hashCode for enum SessionState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SessionState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SessionState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SessionState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SessionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SessionState" />.</param>

        public static implicit operator SessionState(string value)
        {
            return new SessionState(value);
        }

        /// <summary>Implicit operator to convert SessionState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SessionState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SessionState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SessionState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionState e2)
        {
            return e2.Equals(e1);
        }
    }
}