// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Extensions;

    /// <summary>
    /// An Activity Log Alert rule condition that is met when all its member conditions are met.
    /// </summary>
    public partial class AlertRuleAllOfCondition :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAllOfCondition,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAllOfConditionInternal
    {

        /// <summary>Backing field for <see cref="AllOf" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition[] _allOf;

        /// <summary>The list of Activity Log Alert rule conditions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition[] AllOf { get => this._allOf; set => this._allOf = value; }

        /// <summary>Creates an new <see cref="AlertRuleAllOfCondition" /> instance.</summary>
        public AlertRuleAllOfCondition()
        {

        }
    }
    /// An Activity Log Alert rule condition that is met when all its member conditions are met.
    public partial interface IAlertRuleAllOfCondition :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.IJsonSerializable
    {
        /// <summary>The list of Activity Log Alert rule conditions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of Activity Log Alert rule conditions.",
        SerializedName = @"allOf",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition[] AllOf { get; set; }

    }
    /// An Activity Log Alert rule condition that is met when all its member conditions are met.
    internal partial interface IAlertRuleAllOfConditionInternal

    {
        /// <summary>The list of Activity Log Alert rule conditions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAlertRuleAnyOfOrLeafCondition[] AllOf { get; set; }

    }
}