// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The type of Auth token.</summary>
    public partial struct TokenType :
        System.IEquatable<TokenType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType OAuth = @"OAuth";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType Pat = @"PAT";

        /// <summary>the value for an instance of the <see cref="TokenType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to TokenType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TokenType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new TokenType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type TokenType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type TokenType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is TokenType && Equals((TokenType)obj);
        }

        /// <summary>Returns hashCode for enum TokenType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for TokenType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="TokenType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private TokenType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to TokenType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TokenType" />.</param>

        public static implicit operator TokenType(string value)
        {
            return new TokenType(value);
        }

        /// <summary>Implicit operator to convert TokenType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="TokenType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum TokenType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum TokenType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType e2)
        {
            return e2.Equals(e1);
        }
    }
}