// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Properties that define an Application Insights component resource.</summary>
    public partial class ApplicationInsightsComponentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>Application Insights Unique ID for your Application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; }

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        /// <summary>
        /// The unique ID of your application. This field mirrors the 'Name' field and cannot be changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string ApplicationId { get => this._applicationId; }

        /// <summary>Backing field for <see cref="ApplicationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType _applicationType;

        /// <summary>Type of application being monitored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType ApplicationType { get => this._applicationType; set => this._applicationType = value; }

        /// <summary>Backing field for <see cref="ConnectionString" /> property.</summary>
        private string _connectionString;

        /// <summary>Application Insights component connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string ConnectionString { get => this._connectionString; }

        /// <summary>Backing field for <see cref="CreationDate" /> property.</summary>
        private global::System.DateTime? _creationDate;

        /// <summary>Creation Date for the Application Insights component, in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationDate { get => this._creationDate; }

        /// <summary>Backing field for <see cref="DisableIPMasking" /> property.</summary>
        private bool? _disableIPMasking;

        /// <summary>Disable IP masking.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? DisableIPMasking { get => this._disableIPMasking; set => this._disableIPMasking = value; }

        /// <summary>Backing field for <see cref="DisableLocalAuth" /> property.</summary>
        private bool? _disableLocalAuth;

        /// <summary>Disable Non-AAD based Auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? DisableLocalAuth { get => this._disableLocalAuth; set => this._disableLocalAuth = value; }

        /// <summary>Backing field for <see cref="FlowType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType? _flowType;

        /// <summary>
        /// Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set
        /// to 'Bluefield' when creating/updating a component via the REST API.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType? FlowType { get => this._flowType; set => this._flowType = value; }

        /// <summary>Backing field for <see cref="ForceCustomerStorageForProfiler" /> property.</summary>
        private bool? _forceCustomerStorageForProfiler;

        /// <summary>Force users to create their own storage account for profiler and debugger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? ForceCustomerStorageForProfiler { get => this._forceCustomerStorageForProfiler; set => this._forceCustomerStorageForProfiler = value; }

        /// <summary>Backing field for <see cref="HockeyAppId" /> property.</summary>
        private string _hockeyAppId;

        /// <summary>
        /// The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string HockeyAppId { get => this._hockeyAppId; set => this._hockeyAppId = value; }

        /// <summary>Backing field for <see cref="HockeyAppToken" /> property.</summary>
        private string _hockeyAppToken;

        /// <summary>
        /// Token used to authenticate communications with between Application Insights and HockeyApp.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string HockeyAppToken { get => this._hockeyAppToken; }

        /// <summary>Backing field for <see cref="ImmediatePurgeDataOn30Day" /> property.</summary>
        private bool? _immediatePurgeDataOn30Day;

        /// <summary>Purge data immediately after 30 days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? ImmediatePurgeDataOn30Day { get => this._immediatePurgeDataOn30Day; set => this._immediatePurgeDataOn30Day = value; }

        /// <summary>Backing field for <see cref="IngestionMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode? _ingestionMode;

        /// <summary>Indicates the flow of the ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode? IngestionMode { get => this._ingestionMode; set => this._ingestionMode = value; }

        /// <summary>Backing field for <see cref="InstrumentationKey" /> property.</summary>
        private string _instrumentationKey;

        /// <summary>
        /// Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for
        /// all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application
        /// Insights component.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string InstrumentationKey { get => this._instrumentationKey; }

        /// <summary>Backing field for <see cref="LaMigrationDate" /> property.</summary>
        private global::System.DateTime? _laMigrationDate;

        /// <summary>The date which the component got migrated to LA, in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? LaMigrationDate { get => this._laMigrationDate; }

        /// <summary>Internal Acessors for AppId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.AppId { get => this._appId; set { {_appId = value;} } }

        /// <summary>Internal Acessors for ApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.ApplicationId { get => this._applicationId; set { {_applicationId = value;} } }

        /// <summary>Internal Acessors for ConnectionString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.ConnectionString { get => this._connectionString; set { {_connectionString = value;} } }

        /// <summary>Internal Acessors for CreationDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.CreationDate { get => this._creationDate; set { {_creationDate = value;} } }

        /// <summary>Internal Acessors for HockeyAppToken</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.HockeyAppToken { get => this._hockeyAppToken; set { {_hockeyAppToken = value;} } }

        /// <summary>Internal Acessors for InstrumentationKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.InstrumentationKey { get => this._instrumentationKey; set { {_instrumentationKey = value;} } }

        /// <summary>Internal Acessors for LaMigrationDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.LaMigrationDate { get => this._laMigrationDate; set { {_laMigrationDate = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrivateLinkScopedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource[] Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.PrivateLinkScopedResource { get => this._privateLinkScopedResource; set { {_privateLinkScopedResource = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponentPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Application name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="PrivateLinkScopedResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource[] _privateLinkScopedResource;

        /// <summary>List of linked private link scope resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get => this._privateLinkScopedResource; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccessForIngestion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? _publicNetworkAccessForIngestion;

        /// <summary>The network access type for accessing Application Insights ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get => this._publicNetworkAccessForIngestion; set => this._publicNetworkAccessForIngestion = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccessForQuery" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? _publicNetworkAccessForQuery;

        /// <summary>The network access type for accessing Application Insights query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get => this._publicNetworkAccessForQuery; set => this._publicNetworkAccessForQuery = value; }

        /// <summary>Backing field for <see cref="RequestSource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource? _requestSource;

        /// <summary>
        /// Describes what tool created this Application Insights component. Customers using this API should set this to the default
        /// 'rest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource? RequestSource { get => this._requestSource; set => this._requestSource = value; }

        /// <summary>Backing field for <see cref="RetentionInDay" /> property.</summary>
        private int? _retentionInDay;

        /// <summary>Retention period in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public int? RetentionInDay { get => this._retentionInDay; set => this._retentionInDay = value; }

        /// <summary>Backing field for <see cref="SamplingPercentage" /> property.</summary>
        private double? _samplingPercentage;

        /// <summary>
        /// Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public double? SamplingPercentage { get => this._samplingPercentage; set => this._samplingPercentage = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Azure Tenant Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="WorkspaceResourceId" /> property.</summary>
        private string _workspaceResourceId;

        /// <summary>
        /// Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an
        /// application with this API version. Applications from older versions will not have this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string WorkspaceResourceId { get => this._workspaceResourceId; set => this._workspaceResourceId = value; }

        /// <summary>Creates an new <see cref="ApplicationInsightsComponentProperties" /> instance.</summary>
        public ApplicationInsightsComponentProperties()
        {

        }
    }
    /// Properties that define an Application Insights component resource.
    public partial interface IApplicationInsightsComponentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Application Insights Unique ID for your Application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Application Insights Unique ID for your Application.",
        SerializedName = @"AppId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get;  }
        /// <summary>
        /// The unique ID of your application. This field mirrors the 'Name' field and cannot be changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique ID of your application. This field mirrors the 'Name' field and cannot be changed.",
        SerializedName = @"ApplicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationId { get;  }
        /// <summary>Type of application being monitored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of application being monitored.",
        SerializedName = @"Application_Type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType ApplicationType { get; set; }
        /// <summary>Application Insights component connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Application Insights component connection string.",
        SerializedName = @"ConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionString { get;  }
        /// <summary>Creation Date for the Application Insights component, in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Creation Date for the Application Insights component, in ISO 8601 format.",
        SerializedName = @"CreationDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationDate { get;  }
        /// <summary>Disable IP masking.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Disable IP masking.",
        SerializedName = @"DisableIpMasking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableIPMasking { get; set; }
        /// <summary>Disable Non-AAD based Auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Disable Non-AAD based Auth.",
        SerializedName = @"DisableLocalAuth",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableLocalAuth { get; set; }
        /// <summary>
        /// Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set
        /// to 'Bluefield' when creating/updating a component via the REST API.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to 'Bluefield' when creating/updating a component via the REST API.",
        SerializedName = @"Flow_Type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType? FlowType { get; set; }
        /// <summary>Force users to create their own storage account for profiler and debugger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Force users to create their own storage account for profiler and debugger.",
        SerializedName = @"ForceCustomerStorageForProfiler",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForceCustomerStorageForProfiler { get; set; }
        /// <summary>
        /// The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.",
        SerializedName = @"HockeyAppId",
        PossibleTypes = new [] { typeof(string) })]
        string HockeyAppId { get; set; }
        /// <summary>
        /// Token used to authenticate communications with between Application Insights and HockeyApp.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Token used to authenticate communications with between Application Insights and HockeyApp.",
        SerializedName = @"HockeyAppToken",
        PossibleTypes = new [] { typeof(string) })]
        string HockeyAppToken { get;  }
        /// <summary>Purge data immediately after 30 days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Purge data immediately after 30 days.",
        SerializedName = @"ImmediatePurgeDataOn30Days",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ImmediatePurgeDataOn30Day { get; set; }
        /// <summary>Indicates the flow of the ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the flow of the ingestion.",
        SerializedName = @"IngestionMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode? IngestionMode { get; set; }
        /// <summary>
        /// Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for
        /// all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application
        /// Insights component.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application Insights component.",
        SerializedName = @"InstrumentationKey",
        PossibleTypes = new [] { typeof(string) })]
        string InstrumentationKey { get;  }
        /// <summary>The date which the component got migrated to LA, in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date which the component got migrated to LA, in ISO 8601 format.",
        SerializedName = @"LaMigrationDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LaMigrationDate { get;  }
        /// <summary>Application name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Application name.",
        SerializedName = @"Name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>List of linked private link scope resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of linked private link scope resources.",
        SerializedName = @"PrivateLinkScopedResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get;  }
        /// <summary>
        /// Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The network access type for accessing Application Insights ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network access type for accessing Application Insights ingestion.",
        SerializedName = @"publicNetworkAccessForIngestion",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary>The network access type for accessing Application Insights query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network access type for accessing Application Insights query.",
        SerializedName = @"publicNetworkAccessForQuery",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary>
        /// Describes what tool created this Application Insights component. Customers using this API should set this to the default
        /// 'rest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes what tool created this Application Insights component. Customers using this API should set this to the default 'rest'.",
        SerializedName = @"Request_Source",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource? RequestSource { get; set; }
        /// <summary>Retention period in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retention period in days.",
        SerializedName = @"RetentionInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionInDay { get; set; }
        /// <summary>
        /// Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.",
        SerializedName = @"SamplingPercentage",
        PossibleTypes = new [] { typeof(double) })]
        double? SamplingPercentage { get; set; }
        /// <summary>Azure Tenant Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure Tenant Id.",
        SerializedName = @"TenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an
        /// application with this API version. Applications from older versions will not have this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an application with this API version. Applications from older versions will not have this property.",
        SerializedName = @"WorkspaceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceResourceId { get; set; }

    }
    /// Properties that define an Application Insights component resource.
    internal partial interface IApplicationInsightsComponentPropertiesInternal

    {
        /// <summary>Application Insights Unique ID for your Application.</summary>
        string AppId { get; set; }
        /// <summary>
        /// The unique ID of your application. This field mirrors the 'Name' field and cannot be changed.
        /// </summary>
        string ApplicationId { get; set; }
        /// <summary>Type of application being monitored.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType ApplicationType { get; set; }
        /// <summary>Application Insights component connection string.</summary>
        string ConnectionString { get; set; }
        /// <summary>Creation Date for the Application Insights component, in ISO 8601 format.</summary>
        global::System.DateTime? CreationDate { get; set; }
        /// <summary>Disable IP masking.</summary>
        bool? DisableIPMasking { get; set; }
        /// <summary>Disable Non-AAD based Auth.</summary>
        bool? DisableLocalAuth { get; set; }
        /// <summary>
        /// Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set
        /// to 'Bluefield' when creating/updating a component via the REST API.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType? FlowType { get; set; }
        /// <summary>Force users to create their own storage account for profiler and debugger.</summary>
        bool? ForceCustomerStorageForProfiler { get; set; }
        /// <summary>
        /// The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
        /// </summary>
        string HockeyAppId { get; set; }
        /// <summary>
        /// Token used to authenticate communications with between Application Insights and HockeyApp.
        /// </summary>
        string HockeyAppToken { get; set; }
        /// <summary>Purge data immediately after 30 days.</summary>
        bool? ImmediatePurgeDataOn30Day { get; set; }
        /// <summary>Indicates the flow of the ingestion.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode? IngestionMode { get; set; }
        /// <summary>
        /// Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for
        /// all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application
        /// Insights component.
        /// </summary>
        string InstrumentationKey { get; set; }
        /// <summary>The date which the component got migrated to LA, in ISO 8601 format.</summary>
        global::System.DateTime? LaMigrationDate { get; set; }
        /// <summary>Application name.</summary>
        string Name { get; set; }
        /// <summary>List of linked private link scope resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get; set; }
        /// <summary>
        /// Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>The network access type for accessing Application Insights ingestion.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary>The network access type for accessing Application Insights query.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary>
        /// Describes what tool created this Application Insights component. Customers using this API should set this to the default
        /// 'rest'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource? RequestSource { get; set; }
        /// <summary>Retention period in days.</summary>
        int? RetentionInDay { get; set; }
        /// <summary>
        /// Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
        /// </summary>
        double? SamplingPercentage { get; set; }
        /// <summary>Azure Tenant Id.</summary>
        string TenantId { get; set; }
        /// <summary>
        /// Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an
        /// application with this API version. Applications from older versions will not have this property.
        /// </summary>
        string WorkspaceResourceId { get; set; }

    }
}