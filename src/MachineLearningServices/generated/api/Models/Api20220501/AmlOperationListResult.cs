// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>An array of operations supported by the resource provider.</summary>
    public partial class AmlOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperationListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperation[] _value;

        /// <summary>
        /// List of AML workspace operations supported by the AML workspace resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AmlOperationListResult" /> instance.</summary>
        public AmlOperationListResult()
        {

        }
    }
    /// An array of operations supported by the resource provider.
    public partial interface IAmlOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of AML workspace operations supported by the AML workspace resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of AML workspace operations supported by the AML workspace resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperation[] Value { get; set; }

    }
    /// An array of operations supported by the resource provider.
    internal partial interface IAmlOperationListResultInternal

    {
        /// <summary>
        /// List of AML workspace operations supported by the AML workspace resource provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlOperation[] Value { get; set; }

    }
}