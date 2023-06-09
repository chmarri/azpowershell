// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Extensions;

    /// <summary>A list of Activity Log Alert rule actions.</summary>
    public partial class ActionList :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionList,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionListInternal
    {

        /// <summary>Backing field for <see cref="ActionGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroup[] _actionGroup;

        /// <summary>The list of the Action Groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroup[] ActionGroup { get => this._actionGroup; set => this._actionGroup = value; }

        /// <summary>Creates an new <see cref="ActionList" /> instance.</summary>
        public ActionList()
        {

        }
    }
    /// A list of Activity Log Alert rule actions.
    public partial interface IActionList :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.IJsonSerializable
    {
        /// <summary>The list of the Action Groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the Action Groups.",
        SerializedName = @"actionGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroup[] ActionGroup { get; set; }

    }
    /// A list of Activity Log Alert rule actions.
    internal partial interface IActionListInternal

    {
        /// <summary>The list of the Action Groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroup[] ActionGroup { get; set; }

    }
}