// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>An Application Insights component feature capabilities</summary>
    public partial class ApplicationInsightsComponentFeatureCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilities,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal
    {

        /// <summary>Backing field for <see cref="AnalyticsIntegration" /> property.</summary>
        private bool? _analyticsIntegration;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? AnalyticsIntegration { get => this._analyticsIntegration; }

        /// <summary>Backing field for <see cref="ApiAccessLevel" /> property.</summary>
        private string _apiAccessLevel;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string ApiAccessLevel { get => this._apiAccessLevel; }

        /// <summary>Backing field for <see cref="ApplicationMap" /> property.</summary>
        private bool? _applicationMap;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? ApplicationMap { get => this._applicationMap; }

        /// <summary>Backing field for <see cref="BurstThrottlePolicy" /> property.</summary>
        private string _burstThrottlePolicy;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string BurstThrottlePolicy { get => this._burstThrottlePolicy; }

        /// <summary>Backing field for <see cref="DailyCap" /> property.</summary>
        private float? _dailyCap;

        /// <summary>Daily data volume cap in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public float? DailyCap { get => this._dailyCap; }

        /// <summary>Backing field for <see cref="DailyCapResetTime" /> property.</summary>
        private float? _dailyCapResetTime;

        /// <summary>Daily data volume cap UTC reset hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public float? DailyCapResetTime { get => this._dailyCapResetTime; }

        /// <summary>Backing field for <see cref="LiveStreamMetric" /> property.</summary>
        private bool? _liveStreamMetric;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? LiveStreamMetric { get => this._liveStreamMetric; }

        /// <summary>Backing field for <see cref="MetadataClass" /> property.</summary>
        private string _metadataClass;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string MetadataClass { get => this._metadataClass; }

        /// <summary>Internal Acessors for AnalyticsIntegration</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.AnalyticsIntegration { get => this._analyticsIntegration; set { {_analyticsIntegration = value;} } }

        /// <summary>Internal Acessors for ApiAccessLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.ApiAccessLevel { get => this._apiAccessLevel; set { {_apiAccessLevel = value;} } }

        /// <summary>Internal Acessors for ApplicationMap</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.ApplicationMap { get => this._applicationMap; set { {_applicationMap = value;} } }

        /// <summary>Internal Acessors for BurstThrottlePolicy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.BurstThrottlePolicy { get => this._burstThrottlePolicy; set { {_burstThrottlePolicy = value;} } }

        /// <summary>Internal Acessors for DailyCap</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.DailyCap { get => this._dailyCap; set { {_dailyCap = value;} } }

        /// <summary>Internal Acessors for DailyCapResetTime</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.DailyCapResetTime { get => this._dailyCapResetTime; set { {_dailyCapResetTime = value;} } }

        /// <summary>Internal Acessors for LiveStreamMetric</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.LiveStreamMetric { get => this._liveStreamMetric; set { {_liveStreamMetric = value;} } }

        /// <summary>Internal Acessors for MetadataClass</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.MetadataClass { get => this._metadataClass; set { {_metadataClass = value;} } }

        /// <summary>Internal Acessors for MultipleStepWebTest</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.MultipleStepWebTest { get => this._multipleStepWebTest; set { {_multipleStepWebTest = value;} } }

        /// <summary>Internal Acessors for OpenSchema</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.OpenSchema { get => this._openSchema; set { {_openSchema = value;} } }

        /// <summary>Internal Acessors for PowerBiIntegration</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.PowerBiIntegration { get => this._powerBiIntegration; set { {_powerBiIntegration = value;} } }

        /// <summary>Internal Acessors for ProactiveDetection</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.ProactiveDetection { get => this._proactiveDetection; set { {_proactiveDetection = value;} } }

        /// <summary>Internal Acessors for SupportExportData</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.SupportExportData { get => this._supportExportData; set { {_supportExportData = value;} } }

        /// <summary>Internal Acessors for ThrottleRate</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.ThrottleRate { get => this._throttleRate; set { {_throttleRate = value;} } }

        /// <summary>Internal Acessors for TrackingType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.TrackingType { get => this._trackingType; set { {_trackingType = value;} } }

        /// <summary>Internal Acessors for WorkItemIntegration</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapabilitiesInternal.WorkItemIntegration { get => this._workItemIntegration; set { {_workItemIntegration = value;} } }

        /// <summary>Backing field for <see cref="MultipleStepWebTest" /> property.</summary>
        private bool? _multipleStepWebTest;

        /// <summary>Whether allow to use multiple steps web test feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? MultipleStepWebTest { get => this._multipleStepWebTest; }

        /// <summary>Backing field for <see cref="OpenSchema" /> property.</summary>
        private bool? _openSchema;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? OpenSchema { get => this._openSchema; }

        /// <summary>Backing field for <see cref="PowerBiIntegration" /> property.</summary>
        private bool? _powerBiIntegration;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? PowerBiIntegration { get => this._powerBiIntegration; }

        /// <summary>Backing field for <see cref="ProactiveDetection" /> property.</summary>
        private bool? _proactiveDetection;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? ProactiveDetection { get => this._proactiveDetection; }

        /// <summary>Backing field for <see cref="SupportExportData" /> property.</summary>
        private bool? _supportExportData;

        /// <summary>Whether allow to use continuous export feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? SupportExportData { get => this._supportExportData; }

        /// <summary>Backing field for <see cref="ThrottleRate" /> property.</summary>
        private float? _throttleRate;

        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public float? ThrottleRate { get => this._throttleRate; }

        /// <summary>Backing field for <see cref="TrackingType" /> property.</summary>
        private string _trackingType;

        /// <summary>The application insights component used tracking type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string TrackingType { get => this._trackingType; }

        /// <summary>Backing field for <see cref="WorkItemIntegration" /> property.</summary>
        private bool? _workItemIntegration;

        /// <summary>Whether allow to use work item integration feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? WorkItemIntegration { get => this._workItemIntegration; }

        /// <summary>
        /// Creates an new <see cref="ApplicationInsightsComponentFeatureCapabilities" /> instance.
        /// </summary>
        public ApplicationInsightsComponentFeatureCapabilities()
        {

        }
    }
    /// An Application Insights component feature capabilities
    public partial interface IApplicationInsightsComponentFeatureCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"AnalyticsIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AnalyticsIntegration { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"ApiAccessLevel",
        PossibleTypes = new [] { typeof(string) })]
        string ApiAccessLevel { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"ApplicationMap",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApplicationMap { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"BurstThrottlePolicy",
        PossibleTypes = new [] { typeof(string) })]
        string BurstThrottlePolicy { get;  }
        /// <summary>Daily data volume cap in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Daily data volume cap in GB.",
        SerializedName = @"DailyCap",
        PossibleTypes = new [] { typeof(float) })]
        float? DailyCap { get;  }
        /// <summary>Daily data volume cap UTC reset hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Daily data volume cap UTC reset hour.",
        SerializedName = @"DailyCapResetTime",
        PossibleTypes = new [] { typeof(float) })]
        float? DailyCapResetTime { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"LiveStreamMetrics",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LiveStreamMetric { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"MetadataClass",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataClass { get;  }
        /// <summary>Whether allow to use multiple steps web test feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Whether allow to use multiple steps web test feature.",
        SerializedName = @"MultipleStepWebTest",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MultipleStepWebTest { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"OpenSchema",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OpenSchema { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"PowerBIIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PowerBiIntegration { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"ProactiveDetection",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProactiveDetection { get;  }
        /// <summary>Whether allow to use continuous export feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Whether allow to use continuous export feature.",
        SerializedName = @"SupportExportData",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportExportData { get;  }
        /// <summary>Reserved, not used now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reserved, not used now.",
        SerializedName = @"ThrottleRate",
        PossibleTypes = new [] { typeof(float) })]
        float? ThrottleRate { get;  }
        /// <summary>The application insights component used tracking type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The application insights component used tracking type.",
        SerializedName = @"TrackingType",
        PossibleTypes = new [] { typeof(string) })]
        string TrackingType { get;  }
        /// <summary>Whether allow to use work item integration feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Whether allow to use work item integration feature.",
        SerializedName = @"WorkItemIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WorkItemIntegration { get;  }

    }
    /// An Application Insights component feature capabilities
    internal partial interface IApplicationInsightsComponentFeatureCapabilitiesInternal

    {
        /// <summary>Reserved, not used now.</summary>
        bool? AnalyticsIntegration { get; set; }
        /// <summary>Reserved, not used now.</summary>
        string ApiAccessLevel { get; set; }
        /// <summary>Reserved, not used now.</summary>
        bool? ApplicationMap { get; set; }
        /// <summary>Reserved, not used now.</summary>
        string BurstThrottlePolicy { get; set; }
        /// <summary>Daily data volume cap in GB.</summary>
        float? DailyCap { get; set; }
        /// <summary>Daily data volume cap UTC reset hour.</summary>
        float? DailyCapResetTime { get; set; }
        /// <summary>Reserved, not used now.</summary>
        bool? LiveStreamMetric { get; set; }
        /// <summary>Reserved, not used now.</summary>
        string MetadataClass { get; set; }
        /// <summary>Whether allow to use multiple steps web test feature.</summary>
        bool? MultipleStepWebTest { get; set; }
        /// <summary>Reserved, not used now.</summary>
        bool? OpenSchema { get; set; }
        /// <summary>Reserved, not used now.</summary>
        bool? PowerBiIntegration { get; set; }
        /// <summary>Reserved, not used now.</summary>
        bool? ProactiveDetection { get; set; }
        /// <summary>Whether allow to use continuous export feature.</summary>
        bool? SupportExportData { get; set; }
        /// <summary>Reserved, not used now.</summary>
        float? ThrottleRate { get; set; }
        /// <summary>The application insights component used tracking type.</summary>
        string TrackingType { get; set; }
        /// <summary>Whether allow to use work item integration feature.</summary>
        bool? WorkItemIntegration { get; set; }

    }
}