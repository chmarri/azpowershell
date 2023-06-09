// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>timeline aggregation information per kind</summary>
    public partial class TimelineAggregation :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ITimelineAggregation,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ITimelineAggregationInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int _count;

        /// <summary>the total items found for a kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind _kind;

        /// <summary>the query kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="TimelineAggregation" /> instance.</summary>
        public TimelineAggregation()
        {

        }
    }
    /// timeline aggregation information per kind
    public partial interface ITimelineAggregation :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>the total items found for a kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"the total items found for a kind",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int Count { get; set; }
        /// <summary>the query kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"the query kind",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get; set; }

    }
    /// timeline aggregation information per kind
    internal partial interface ITimelineAggregationInternal

    {
        /// <summary>the total items found for a kind</summary>
        int Count { get; set; }
        /// <summary>the query kind</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get; set; }

    }
}