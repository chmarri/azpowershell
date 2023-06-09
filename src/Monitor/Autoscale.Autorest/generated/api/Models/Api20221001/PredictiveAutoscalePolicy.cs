// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>The parameters for enabling predictive autoscale.</summary>
    public partial class PredictiveAutoscalePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IPredictiveAutoscalePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IPredictiveAutoscalePolicyInternal
    {

        /// <summary>Backing field for <see cref="ScaleLookAheadTime" /> property.</summary>
        private global::System.TimeSpan? _scaleLookAheadTime;

        /// <summary>
        /// the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in
        /// ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.PropertyOrigin.Owned)]
        public global::System.TimeSpan? ScaleLookAheadTime { get => this._scaleLookAheadTime; set => this._scaleLookAheadTime = value; }

        /// <summary>Backing field for <see cref="ScaleMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.PredictiveAutoscalePolicyScaleMode _scaleMode;

        /// <summary>the predictive autoscale mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.PredictiveAutoscalePolicyScaleMode ScaleMode { get => this._scaleMode; set => this._scaleMode = value; }

        /// <summary>Creates an new <see cref="PredictiveAutoscalePolicy" /> instance.</summary>
        public PredictiveAutoscalePolicy()
        {

        }
    }
    /// The parameters for enabling predictive autoscale.
    public partial interface IPredictiveAutoscalePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IJsonSerializable
    {
        /// <summary>
        /// the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in
        /// ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in ISO 8601 format.",
        SerializedName = @"scaleLookAheadTime",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? ScaleLookAheadTime { get; set; }
        /// <summary>the predictive autoscale mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"the predictive autoscale mode",
        SerializedName = @"scaleMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.PredictiveAutoscalePolicyScaleMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.PredictiveAutoscalePolicyScaleMode ScaleMode { get; set; }

    }
    /// The parameters for enabling predictive autoscale.
    internal partial interface IPredictiveAutoscalePolicyInternal

    {
        /// <summary>
        /// the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in
        /// ISO 8601 format.
        /// </summary>
        global::System.TimeSpan? ScaleLookAheadTime { get; set; }
        /// <summary>the predictive autoscale mode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.PredictiveAutoscalePolicyScaleMode ScaleMode { get; set; }

    }
}