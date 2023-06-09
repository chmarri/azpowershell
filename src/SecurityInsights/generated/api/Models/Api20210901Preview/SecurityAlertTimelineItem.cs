// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Represents security alert timeline item.</summary>
    public partial class SecurityAlertTimelineItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertTimelineItem,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertTimelineItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItem __entityTimelineItem = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityTimelineItem();

        /// <summary>Backing field for <see cref="AlertType" /> property.</summary>
        private string _alertType;

        /// <summary>The name of the alert type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string AlertType { get => this._alertType; set => this._alertType = value; }

        /// <summary>Backing field for <see cref="AzureResourceId" /> property.</summary>
        private string _azureResourceId;

        /// <summary>The alert azure resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string AzureResourceId { get => this._azureResourceId; set => this._azureResourceId = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The alert description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The alert name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EndTimeUtc" /> property.</summary>
        private global::System.DateTime _endTimeUtc;

        /// <summary>The alert end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime EndTimeUtc { get => this._endTimeUtc; set => this._endTimeUtc = value; }

        /// <summary>The entity query kind type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItemInternal)__entityTimelineItem).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItemInternal)__entityTimelineItem).Kind = value ; }

        /// <summary>Backing field for <see cref="ProductName" /> property.</summary>
        private string _productName;

        /// <summary>The alert product name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ProductName { get => this._productName; set => this._productName = value; }

        /// <summary>Backing field for <see cref="Severity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity _severity;

        /// <summary>The alert severity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity Severity { get => this._severity; set => this._severity = value; }

        /// <summary>Backing field for <see cref="StartTimeUtc" /> property.</summary>
        private global::System.DateTime _startTimeUtc;

        /// <summary>The alert start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime StartTimeUtc { get => this._startTimeUtc; set => this._startTimeUtc = value; }

        /// <summary>Backing field for <see cref="TimeGenerated" /> property.</summary>
        private global::System.DateTime _timeGenerated;

        /// <summary>The alert generated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime TimeGenerated { get => this._timeGenerated; set => this._timeGenerated = value; }

        /// <summary>Creates an new <see cref="SecurityAlertTimelineItem" /> instance.</summary>
        public SecurityAlertTimelineItem()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityTimelineItem), __entityTimelineItem);
            await eventListener.AssertObjectIsValid(nameof(__entityTimelineItem), __entityTimelineItem);
        }
    }
    /// Represents security alert timeline item.
    public partial interface ISecurityAlertTimelineItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItem
    {
        /// <summary>The name of the alert type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the alert type.",
        SerializedName = @"alertType",
        PossibleTypes = new [] { typeof(string) })]
        string AlertType { get; set; }
        /// <summary>The alert azure resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert azure resource id.",
        SerializedName = @"azureResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureResourceId { get; set; }
        /// <summary>The alert description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alert description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The alert name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The alert end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert end time.",
        SerializedName = @"endTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EndTimeUtc { get; set; }
        /// <summary>The alert product name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alert product name.",
        SerializedName = @"productName",
        PossibleTypes = new [] { typeof(string) })]
        string ProductName { get; set; }
        /// <summary>The alert severity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert severity.",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity Severity { get; set; }
        /// <summary>The alert start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert start time.",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTimeUtc { get; set; }
        /// <summary>The alert generated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alert generated time.",
        SerializedName = @"timeGenerated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime TimeGenerated { get; set; }

    }
    /// Represents security alert timeline item.
    internal partial interface ISecurityAlertTimelineItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItemInternal
    {
        /// <summary>The name of the alert type.</summary>
        string AlertType { get; set; }
        /// <summary>The alert azure resource id.</summary>
        string AzureResourceId { get; set; }
        /// <summary>The alert description.</summary>
        string Description { get; set; }
        /// <summary>The alert name.</summary>
        string DisplayName { get; set; }
        /// <summary>The alert end time.</summary>
        global::System.DateTime EndTimeUtc { get; set; }
        /// <summary>The alert product name.</summary>
        string ProductName { get; set; }
        /// <summary>The alert severity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity Severity { get; set; }
        /// <summary>The alert start time.</summary>
        global::System.DateTime StartTimeUtc { get; set; }
        /// <summary>The alert generated time.</summary>
        global::System.DateTime TimeGenerated { get; set; }

    }
}