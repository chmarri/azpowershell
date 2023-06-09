// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;

    /// <summary>The diagnostic settings.</summary>
    public partial class DiagnosticSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsInternal
    {

        /// <summary>Backing field for <see cref="EventHubAuthorizationRuleId" /> property.</summary>
        private string _eventHubAuthorizationRuleId;

        /// <summary>The resource Id for the event hub authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string EventHubAuthorizationRuleId { get => this._eventHubAuthorizationRuleId; set => this._eventHubAuthorizationRuleId = value; }

        /// <summary>Backing field for <see cref="EventHubName" /> property.</summary>
        private string _eventHubName;

        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string EventHubName { get => this._eventHubName; set => this._eventHubName = value; }

        /// <summary>Backing field for <see cref="Log" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ILogSettings[] _log;

        /// <summary>The list of logs settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ILogSettings[] Log { get => this._log; set => this._log = value; }

        /// <summary>Backing field for <see cref="LogAnalyticsDestinationType" /> property.</summary>
        private string _logAnalyticsDestinationType;

        /// <summary>
        /// A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics,
        /// or use a destination type constructed as follows: <normalized service identity>_<normalized category name>. Possible values
        /// are: Dedicated and null (null is default.)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string LogAnalyticsDestinationType { get => this._logAnalyticsDestinationType; set => this._logAnalyticsDestinationType = value; }

        /// <summary>Backing field for <see cref="MarketplacePartnerId" /> property.</summary>
        private string _marketplacePartnerId;

        /// <summary>
        /// The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string MarketplacePartnerId { get => this._marketplacePartnerId; set => this._marketplacePartnerId = value; }

        /// <summary>Backing field for <see cref="Metric" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings[] _metric;

        /// <summary>The list of metric settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings[] Metric { get => this._metric; set => this._metric = value; }

        /// <summary>Backing field for <see cref="ServiceBusRuleId" /> property.</summary>
        private string _serviceBusRuleId;

        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string ServiceBusRuleId { get => this._serviceBusRuleId; set => this._serviceBusRuleId = value; }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Backing field for <see cref="WorkspaceId" /> property.</summary>
        private string _workspaceId;

        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public string WorkspaceId { get => this._workspaceId; set => this._workspaceId = value; }

        /// <summary>Creates an new <see cref="DiagnosticSettings" /> instance.</summary>
        public DiagnosticSettings()
        {

        }
    }
    /// The diagnostic settings.
    public partial interface IDiagnosticSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IJsonSerializable
    {
        /// <summary>The resource Id for the event hub authorization rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource Id for the event hub authorization rule.",
        SerializedName = @"eventHubAuthorizationRuleId",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubAuthorizationRuleId { get; set; }
        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the event hub. If none is specified, the default event hub will be selected.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubName { get; set; }
        /// <summary>The list of logs settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of logs settings.",
        SerializedName = @"logs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ILogSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ILogSettings[] Log { get; set; }
        /// <summary>
        /// A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics,
        /// or use a destination type constructed as follows: <normalized service identity>_<normalized category name>. Possible values
        /// are: Dedicated and null (null is default.)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: <normalized service identity>_<normalized category name>. Possible values are: Dedicated and null (null is default.)",
        SerializedName = @"logAnalyticsDestinationType",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticsDestinationType { get; set; }
        /// <summary>
        /// The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.",
        SerializedName = @"marketplacePartnerId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplacePartnerId { get; set; }
        /// <summary>The list of metric settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of metric settings.",
        SerializedName = @"metrics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings[] Metric { get; set; }
        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.",
        SerializedName = @"serviceBusRuleId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceBusRuleId { get; set; }
        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the storage account to which you would like to send Diagnostic Logs.",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }
        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get; set; }

    }
    /// The diagnostic settings.
    internal partial interface IDiagnosticSettingsInternal

    {
        /// <summary>The resource Id for the event hub authorization rule.</summary>
        string EventHubAuthorizationRuleId { get; set; }
        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        string EventHubName { get; set; }
        /// <summary>The list of logs settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ILogSettings[] Log { get; set; }
        /// <summary>
        /// A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics,
        /// or use a destination type constructed as follows: <normalized service identity>_<normalized category name>. Possible values
        /// are: Dedicated and null (null is default.)
        /// </summary>
        string LogAnalyticsDestinationType { get; set; }
        /// <summary>
        /// The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.
        /// </summary>
        string MarketplacePartnerId { get; set; }
        /// <summary>The list of metric settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IMetricSettings[] Metric { get; set; }
        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        string ServiceBusRuleId { get; set; }
        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        string StorageAccountId { get; set; }
        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        string WorkspaceId { get; set; }

    }
}