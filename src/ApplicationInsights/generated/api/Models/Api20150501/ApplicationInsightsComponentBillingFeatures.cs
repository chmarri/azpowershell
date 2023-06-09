// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>An Application Insights component billing features</summary>
    public partial class ApplicationInsightsComponentBillingFeatures :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentBillingFeatures,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentBillingFeaturesInternal
    {

        /// <summary>Backing field for <see cref="CurrentBillingFeature" /> property.</summary>
        private string[] _currentBillingFeature;

        /// <summary>
        /// Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application
        /// Insights Enterprise'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string[] CurrentBillingFeature { get => this._currentBillingFeature; set => this._currentBillingFeature = value; }

        /// <summary>Backing field for <see cref="DataVolumeCap" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCap _dataVolumeCap;

        /// <summary>An Application Insights component daily data volume cap</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCap DataVolumeCap { get => (this._dataVolumeCap = this._dataVolumeCap ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentDataVolumeCap()); set => this._dataVolumeCap = value; }

        /// <summary>Daily data volume cap in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public float? DataVolumeCapCap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).Cap; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).Cap = value ?? default(float); }

        /// <summary>Maximum daily data volume cap that the user can set for this component.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public float? DataVolumeCapMaxHistoryCap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).MaxHistoryCap; }

        /// <summary>Daily data volume cap UTC reset hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public int? DataVolumeCapResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).ResetTime; }

        /// <summary>Do not send a notification email when the daily data volume cap is met.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? DataVolumeCapStopSendNotificationWhenHitCap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).StopSendNotificationWhenHitCap; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).StopSendNotificationWhenHitCap = value ?? default(bool); }

        /// <summary>Reserved, not used for now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? DataVolumeCapStopSendNotificationWhenHitThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).StopSendNotificationWhenHitThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).StopSendNotificationWhenHitThreshold = value ?? default(bool); }

        /// <summary>Reserved, not used for now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public int? DataVolumeCapWarningThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).WarningThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).WarningThreshold = value ?? default(int); }

        /// <summary>Internal Acessors for DataVolumeCap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCap Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentBillingFeaturesInternal.DataVolumeCap { get => (this._dataVolumeCap = this._dataVolumeCap ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentDataVolumeCap()); set { {_dataVolumeCap = value;} } }

        /// <summary>Internal Acessors for DataVolumeCapMaxHistoryCap</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentBillingFeaturesInternal.DataVolumeCapMaxHistoryCap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).MaxHistoryCap; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).MaxHistoryCap = value; }

        /// <summary>Internal Acessors for DataVolumeCapResetTime</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentBillingFeaturesInternal.DataVolumeCapResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).ResetTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCapInternal)DataVolumeCap).ResetTime = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationInsightsComponentBillingFeatures" /> instance.
        /// </summary>
        public ApplicationInsightsComponentBillingFeatures()
        {

        }
    }
    /// An Application Insights component billing features
    public partial interface IApplicationInsightsComponentBillingFeatures :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application
        /// Insights Enterprise'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application Insights Enterprise'.",
        SerializedName = @"CurrentBillingFeatures",
        PossibleTypes = new [] { typeof(string) })]
        string[] CurrentBillingFeature { get; set; }
        /// <summary>Daily data volume cap in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Daily data volume cap in GB.",
        SerializedName = @"Cap",
        PossibleTypes = new [] { typeof(float) })]
        float? DataVolumeCapCap { get; set; }
        /// <summary>Maximum daily data volume cap that the user can set for this component.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum daily data volume cap that the user can set for this component.",
        SerializedName = @"MaxHistoryCap",
        PossibleTypes = new [] { typeof(float) })]
        float? DataVolumeCapMaxHistoryCap { get;  }
        /// <summary>Daily data volume cap UTC reset hour.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Daily data volume cap UTC reset hour.",
        SerializedName = @"ResetTime",
        PossibleTypes = new [] { typeof(int) })]
        int? DataVolumeCapResetTime { get;  }
        /// <summary>Do not send a notification email when the daily data volume cap is met.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do not send a notification email when the daily data volume cap is met.",
        SerializedName = @"StopSendNotificationWhenHitCap",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DataVolumeCapStopSendNotificationWhenHitCap { get; set; }
        /// <summary>Reserved, not used for now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reserved, not used for now.",
        SerializedName = @"StopSendNotificationWhenHitThreshold",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DataVolumeCapStopSendNotificationWhenHitThreshold { get; set; }
        /// <summary>Reserved, not used for now.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reserved, not used for now.",
        SerializedName = @"WarningThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? DataVolumeCapWarningThreshold { get; set; }

    }
    /// An Application Insights component billing features
    internal partial interface IApplicationInsightsComponentBillingFeaturesInternal

    {
        /// <summary>
        /// Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application
        /// Insights Enterprise'.
        /// </summary>
        string[] CurrentBillingFeature { get; set; }
        /// <summary>An Application Insights component daily data volume cap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentDataVolumeCap DataVolumeCap { get; set; }
        /// <summary>Daily data volume cap in GB.</summary>
        float? DataVolumeCapCap { get; set; }
        /// <summary>Maximum daily data volume cap that the user can set for this component.</summary>
        float? DataVolumeCapMaxHistoryCap { get; set; }
        /// <summary>Daily data volume cap UTC reset hour.</summary>
        int? DataVolumeCapResetTime { get; set; }
        /// <summary>Do not send a notification email when the daily data volume cap is met.</summary>
        bool? DataVolumeCapStopSendNotificationWhenHitCap { get; set; }
        /// <summary>Reserved, not used for now.</summary>
        bool? DataVolumeCapStopSendNotificationWhenHitThreshold { get; set; }
        /// <summary>Reserved, not used for now.</summary>
        int? DataVolumeCapWarningThreshold { get; set; }

    }
}