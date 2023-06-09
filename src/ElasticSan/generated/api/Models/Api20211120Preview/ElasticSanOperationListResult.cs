// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>List of operations supported by the RP.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.DoNotFormat]
    public partial class ElasticSanOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanOperationListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to fetch the next section of the paginated response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanRpOperation[] _value;

        /// <summary>An array of operations supported by the ElasticSan RP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanRpOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ElasticSanOperationListResult" /> instance.</summary>
        public ElasticSanOperationListResult()
        {

        }
    }
    /// List of operations supported by the RP.
    public partial interface IElasticSanOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>URI to fetch the next section of the paginated response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to fetch the next section of the paginated response.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>An array of operations supported by the ElasticSan RP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An array of operations supported by the ElasticSan RP.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanRpOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanRpOperation[] Value { get; set; }

    }
    /// List of operations supported by the RP.
    internal partial interface IElasticSanOperationListResultInternal

    {
        /// <summary>URI to fetch the next section of the paginated response.</summary>
        string NextLink { get; set; }
        /// <summary>An array of operations supported by the ElasticSan RP.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IElasticSanRpOperation[] Value { get; set; }

    }
}