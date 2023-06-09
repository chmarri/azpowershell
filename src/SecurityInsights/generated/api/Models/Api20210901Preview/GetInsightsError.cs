// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>GetInsights Query Errors.</summary>
    public partial class GetInsightsError :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IGetInsightsError,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IGetInsightsErrorInternal
    {

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>the error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; set => this._errorMessage = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind= @"Insight";

        /// <summary>the query kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IGetInsightsErrorInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Backing field for <see cref="QueryId" /> property.</summary>
        private string _queryId;

        /// <summary>the query id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string QueryId { get => this._queryId; set => this._queryId = value; }

        /// <summary>Creates an new <see cref="GetInsightsError" /> instance.</summary>
        public GetInsightsError()
        {

        }
    }
    /// GetInsights Query Errors.
    public partial interface IGetInsightsError :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>the error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"the error message",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get; set; }
        /// <summary>the query kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"the query kind",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }
        /// <summary>the query id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the query id",
        SerializedName = @"queryId",
        PossibleTypes = new [] { typeof(string) })]
        string QueryId { get; set; }

    }
    /// GetInsights Query Errors.
    internal partial interface IGetInsightsErrorInternal

    {
        /// <summary>the error message</summary>
        string ErrorMessage { get; set; }
        /// <summary>the query kind</summary>
        string Kind { get; set; }
        /// <summary>the query id</summary>
        string QueryId { get; set; }

    }
}