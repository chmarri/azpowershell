// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Fusion alert rule base property bag.</summary>
    public partial class FusionAlertRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRuleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AlertRuleTemplateName" /> property.</summary>
        private string _alertRuleTemplateName;

        /// <summary>The Name of the alert rule template used to create this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string AlertRuleTemplateName { get => this._alertRuleTemplateName; set => this._alertRuleTemplateName = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name for alerts created by this alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool _enabled;

        /// <summary>Determines whether this alert rule is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="LastModifiedUtc" /> property.</summary>
        private global::System.DateTime? _lastModifiedUtc;

        /// <summary>The last time that this alert has been modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedUtc { get => this._lastModifiedUtc; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for LastModifiedUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal.LastModifiedUtc { get => this._lastModifiedUtc; set { {_lastModifiedUtc = value;} } }

        /// <summary>Internal Acessors for Severity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal.Severity { get => this._severity; set { {_severity = value;} } }

        /// <summary>Internal Acessors for Tactic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[] Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IFusionAlertRulePropertiesInternal.Tactic { get => this._tactic; set { {_tactic = value;} } }

        /// <summary>Backing field for <see cref="Severity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity? _severity;

        /// <summary>The severity for alerts created by this alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity? Severity { get => this._severity; }

        /// <summary>Backing field for <see cref="Tactic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[] _tactic;

        /// <summary>The tactics of the alert rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[] Tactic { get => this._tactic; }

        /// <summary>Creates an new <see cref="FusionAlertRuleProperties" /> instance.</summary>
        public FusionAlertRuleProperties()
        {

        }
    }
    /// Fusion alert rule base property bag.
    public partial interface IFusionAlertRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The Name of the alert rule template used to create this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Name of the alert rule template used to create this rule.",
        SerializedName = @"alertRuleTemplateName",
        PossibleTypes = new [] { typeof(string) })]
        string AlertRuleTemplateName { get; set; }
        /// <summary>The description of the alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The description of the alert rule.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The display name for alerts created by this alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The display name for alerts created by this alert rule.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Determines whether this alert rule is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Determines whether this alert rule is enabled or disabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool Enabled { get; set; }
        /// <summary>The last time that this alert has been modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time that this alert has been modified.",
        SerializedName = @"lastModifiedUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedUtc { get;  }
        /// <summary>The severity for alerts created by this alert rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The severity for alerts created by this alert rule.",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity? Severity { get;  }
        /// <summary>The tactics of the alert rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tactics of the alert rule",
        SerializedName = @"tactics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[] Tactic { get;  }

    }
    /// Fusion alert rule base property bag.
    internal partial interface IFusionAlertRulePropertiesInternal

    {
        /// <summary>The Name of the alert rule template used to create this rule.</summary>
        string AlertRuleTemplateName { get; set; }
        /// <summary>The description of the alert rule.</summary>
        string Description { get; set; }
        /// <summary>The display name for alerts created by this alert rule.</summary>
        string DisplayName { get; set; }
        /// <summary>Determines whether this alert rule is enabled or disabled.</summary>
        bool Enabled { get; set; }
        /// <summary>The last time that this alert has been modified.</summary>
        global::System.DateTime? LastModifiedUtc { get; set; }
        /// <summary>The severity for alerts created by this alert rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity? Severity { get; set; }
        /// <summary>The tactics of the alert rule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[] Tactic { get; set; }

    }
}