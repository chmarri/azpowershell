// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>The parameters required to execute s timeline operation on the given entity.</summary>
    public partial class EntityTimelineParameters :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineParameters,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineParametersInternal
    {

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime _endTime;

        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind[] _kind;

        /// <summary>Array of timeline Item kinds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind[] Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="NumberOfBucket" /> property.</summary>
        private int? _numberOfBucket;

        /// <summary>The number of bucket for timeline queries aggregation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int? NumberOfBucket { get => this._numberOfBucket; set => this._numberOfBucket = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime _startTime;

        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Creates an new <see cref="EntityTimelineParameters" /> instance.</summary>
        public EntityTimelineParameters()
        {

        }
    }
    /// The parameters required to execute s timeline operation on the given entity.
    public partial interface IEntityTimelineParameters :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The end timeline date, so the results returned are before this date.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EndTime { get; set; }
        /// <summary>Array of timeline Item kinds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of timeline Item kinds.",
        SerializedName = @"kinds",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind[] Kind { get; set; }
        /// <summary>The number of bucket for timeline queries aggregation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of bucket for timeline queries aggregation.",
        SerializedName = @"numberOfBucket",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfBucket { get; set; }
        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The start timeline date, so the results returned are after this date.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTime { get; set; }

    }
    /// The parameters required to execute s timeline operation on the given entity.
    internal partial interface IEntityTimelineParametersInternal

    {
        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        global::System.DateTime EndTime { get; set; }
        /// <summary>Array of timeline Item kinds.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind[] Kind { get; set; }
        /// <summary>The number of bucket for timeline queries aggregation.</summary>
        int? NumberOfBucket { get; set; }
        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        global::System.DateTime StartTime { get; set; }

    }
}