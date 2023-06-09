// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    /// <summary>Query properties</summary>
    public partial class QueryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Column" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryColumn[] _column;

        /// <summary>Array of columns</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryColumn[] Column { get => this._column; set => this._column = value; }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link (url) to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Row" /> property.</summary>
        private string[][] _row;

        /// <summary>Array of rows</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string[][] Row { get => this._row; set => this._row = value; }

        /// <summary>Creates an new <see cref="QueryProperties" /> instance.</summary>
        public QueryProperties()
        {

        }
    }
    /// Query properties
    public partial interface IQueryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>Array of columns</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of columns",
        SerializedName = @"columns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryColumn) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryColumn[] Column { get; set; }
        /// <summary>The link (url) to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link (url) to the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of rows</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of rows",
        SerializedName = @"rows",
        PossibleTypes = new [] { typeof(string) })]
        string[][] Row { get; set; }

    }
    /// Query properties
    public partial interface IQueryPropertiesInternal

    {
        /// <summary>Array of columns</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IQueryColumn[] Column { get; set; }
        /// <summary>The link (url) to the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Array of rows</summary>
        string[][] Row { get; set; }

    }
}