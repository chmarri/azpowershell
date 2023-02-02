// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The password name "password1" or "password2"</summary>
    public partial struct TokenPasswordName :
        System.IEquatable<TokenPasswordName>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName Password1 = @"password1";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName Password2 = @"password2";

        /// <summary>the value for an instance of the <see cref="TokenPasswordName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to TokenPasswordName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TokenPasswordName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new TokenPasswordName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type TokenPasswordName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type TokenPasswordName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is TokenPasswordName && Equals((TokenPasswordName)obj);
        }

        /// <summary>Returns hashCode for enum TokenPasswordName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for TokenPasswordName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="TokenPasswordName"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private TokenPasswordName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to TokenPasswordName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TokenPasswordName" />.</param>

        public static implicit operator TokenPasswordName(string value)
        {
            return new TokenPasswordName(value);
        }

        /// <summary>Implicit operator to convert TokenPasswordName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="TokenPasswordName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum TokenPasswordName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum TokenPasswordName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName e2)
        {
            return e2.Equals(e1);
        }
    }
}