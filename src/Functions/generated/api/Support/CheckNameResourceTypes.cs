// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Resource type used for verification.</summary>
    public partial struct CheckNameResourceTypes :
        System.IEquatable<CheckNameResourceTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes HostingEnvironment = @"HostingEnvironment";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes MicrosoftWebHostingEnvironments = @"Microsoft.Web/hostingEnvironments";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes MicrosoftWebPublishingUsers = @"Microsoft.Web/publishingUsers";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes MicrosoftWebSites = @"Microsoft.Web/sites";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes MicrosoftWebSitesSlots = @"Microsoft.Web/sites/slots";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes PublishingUser = @"PublishingUser";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes Site = @"Site";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes Slot = @"Slot";

        /// <summary>the value for an instance of the <see cref="CheckNameResourceTypes" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="CheckNameResourceTypes"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CheckNameResourceTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to CheckNameResourceTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CheckNameResourceTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CheckNameResourceTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type CheckNameResourceTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CheckNameResourceTypes (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CheckNameResourceTypes && Equals((CheckNameResourceTypes)obj);
        }

        /// <summary>Returns hashCode for enum CheckNameResourceTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CheckNameResourceTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CheckNameResourceTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CheckNameResourceTypes" />.</param>

        public static implicit operator CheckNameResourceTypes(string value)
        {
            return new CheckNameResourceTypes(value);
        }

        /// <summary>Implicit operator to convert CheckNameResourceTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CheckNameResourceTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CheckNameResourceTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CheckNameResourceTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}