// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>Type of Payload body for Base image update triggers.</summary>
    public partial struct UpdateTriggerPayloadType :
        System.IEquatable<UpdateTriggerPayloadType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType Default = @"Default";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType Token = @"Token";

        /// <summary>the value for an instance of the <see cref="UpdateTriggerPayloadType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UpdateTriggerPayloadType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateTriggerPayloadType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UpdateTriggerPayloadType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UpdateTriggerPayloadType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UpdateTriggerPayloadType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UpdateTriggerPayloadType && Equals((UpdateTriggerPayloadType)obj);
        }

        /// <summary>Returns hashCode for enum UpdateTriggerPayloadType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UpdateTriggerPayloadType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UpdateTriggerPayloadType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UpdateTriggerPayloadType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UpdateTriggerPayloadType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateTriggerPayloadType" />.</param>

        public static implicit operator UpdateTriggerPayloadType(string value)
        {
            return new UpdateTriggerPayloadType(value);
        }

        /// <summary>Implicit operator to convert UpdateTriggerPayloadType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UpdateTriggerPayloadType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UpdateTriggerPayloadType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UpdateTriggerPayloadType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType e2)
        {
            return e2.Equals(e1);
        }
    }
}