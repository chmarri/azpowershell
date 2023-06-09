// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>Enum to determine the Job Output Type.</summary>
    public partial struct JobOutputType :
        System.IEquatable<JobOutputType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType CustomModel = @"custom_model";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType MlflowModel = @"mlflow_model";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType Mltable = @"mltable";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType TritonModel = @"triton_model";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType UriFile = @"uri_file";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType UriFolder = @"uri_folder";

        /// <summary>the value for an instance of the <see cref="JobOutputType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to JobOutputType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="JobOutputType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new JobOutputType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type JobOutputType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type JobOutputType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is JobOutputType && Equals((JobOutputType)obj);
        }

        /// <summary>Returns hashCode for enum JobOutputType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="JobOutputType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private JobOutputType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for JobOutputType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to JobOutputType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="JobOutputType" />.</param>

        public static implicit operator JobOutputType(string value)
        {
            return new JobOutputType(value);
        }

        /// <summary>Implicit operator to convert JobOutputType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="JobOutputType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum JobOutputType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum JobOutputType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType e2)
        {
            return e2.Equals(e1);
        }
    }
}