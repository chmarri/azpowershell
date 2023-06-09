// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;

    /// <summary>
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a particular metric.
    /// </summary>
    public partial class MetricSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettingsInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic
        /// metric categories for a resource, first perform a GET diagnostic settings operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool _enabled;

        /// <summary>a value indicating whether this category is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public bool Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Internal Acessors for RetentionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicy Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettingsInternal.RetentionPolicy { get => (this._retentionPolicy = this._retentionPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.RetentionPolicy()); set { {_retentionPolicy = value;} } }

        /// <summary>Backing field for <see cref="RetentionPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicy _retentionPolicy;

        /// <summary>the retention policy for this category.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicy RetentionPolicy { get => (this._retentionPolicy = this._retentionPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.RetentionPolicy()); set => this._retentionPolicy = value; }

        /// <summary>
        /// the number of days for the retention in days. A value of 0 will retain the events indefinitely.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Inlined)]
        public int? RetentionPolicyDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicyInternal)RetentionPolicy).Day; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicyInternal)RetentionPolicy).Day = value ?? default(int); }

        /// <summary>a value indicating whether the retention policy is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Inlined)]
        public bool? RetentionPolicyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicyInternal)RetentionPolicy).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicyInternal)RetentionPolicy).Enabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="TimeGrain" /> property.</summary>
        private global::System.TimeSpan? _timeGrain;

        /// <summary>the timegrain of the metric in ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public global::System.TimeSpan? TimeGrain { get => this._timeGrain; set => this._timeGrain = value; }

        /// <summary>Creates an new <see cref="MetricSettings" /> instance.</summary>
        public MetricSettings()
        {

        }
    }
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a particular metric.
    public partial interface IMetricSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic
        /// metric categories for a resource, first perform a GET diagnostic settings operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic metric categories for a resource, first perform a GET diagnostic settings operation.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>a value indicating whether this category is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"a value indicating whether this category is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool Enabled { get; set; }
        /// <summary>
        /// the number of days for the retention in days. A value of 0 will retain the events indefinitely.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the number of days for the retention in days. A value of 0 will retain the events indefinitely.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPolicyDay { get; set; }
        /// <summary>a value indicating whether the retention policy is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"a value indicating whether the retention policy is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RetentionPolicyEnabled { get; set; }
        /// <summary>the timegrain of the metric in ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the timegrain of the metric in ISO8601 format.",
        SerializedName = @"timeGrain",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? TimeGrain { get; set; }

    }
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a particular metric.
    internal partial interface IMetricSettingsInternal

    {
        /// <summary>
        /// Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic
        /// metric categories for a resource, first perform a GET diagnostic settings operation.
        /// </summary>
        string Category { get; set; }
        /// <summary>a value indicating whether this category is enabled.</summary>
        bool Enabled { get; set; }
        /// <summary>the retention policy for this category.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IRetentionPolicy RetentionPolicy { get; set; }
        /// <summary>
        /// the number of days for the retention in days. A value of 0 will retain the events indefinitely.
        /// </summary>
        int? RetentionPolicyDay { get; set; }
        /// <summary>a value indicating whether the retention policy is enabled.</summary>
        bool? RetentionPolicyEnabled { get; set; }
        /// <summary>the timegrain of the metric in ISO8601 format.</summary>
        global::System.TimeSpan? TimeGrain { get; set; }

    }
}