// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    public partial class InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItemInternal
    {

        /// <summary>Backing field for <see cref="Header" /> property.</summary>
        private string _header;

        /// <summary>Insight column header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Header { get => this._header; set => this._header = value; }

        /// <summary>Backing field for <see cref="OutputType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType? _outputType;

        /// <summary>Insights Column type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType? OutputType { get => this._outputType; set => this._outputType = value; }

        /// <summary>Backing field for <see cref="SupportDeepLink" /> property.</summary>
        private bool? _supportDeepLink;

        /// <summary>Is query supports deep-link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? SupportDeepLink { get => this._supportDeepLink; set => this._supportDeepLink = value; }

        /// <summary>
        /// Creates an new <see cref="InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem" /> instance.
        /// </summary>
        public InsightQueryItemPropertiesTableQueryColumnsDefinitionsItem()
        {

        }
    }
    public partial interface IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Insight column header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Insight column header.",
        SerializedName = @"header",
        PossibleTypes = new [] { typeof(string) })]
        string Header { get; set; }
        /// <summary>Insights Column type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Insights Column type.",
        SerializedName = @"outputType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType? OutputType { get; set; }
        /// <summary>Is query supports deep-link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is query supports deep-link.",
        SerializedName = @"supportDeepLink",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportDeepLink { get; set; }

    }
    internal partial interface IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItemInternal

    {
        /// <summary>Insight column header.</summary>
        string Header { get; set; }
        /// <summary>Insights Column type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType? OutputType { get; set; }
        /// <summary>Is query supports deep-link.</summary>
        bool? SupportDeepLink { get; set; }

    }
}