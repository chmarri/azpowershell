// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Describes an automation rule action</summary>
    public partial class AutomationRuleAction :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleAction,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal
    {

        /// <summary>Backing field for <see cref="ActionType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType _actionType;

        /// <summary>The type of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType ActionType { get => this._actionType; set => this._actionType = value; }

        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private int _order;

        /// <summary>The order of execution of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int Order { get => this._order; set => this._order = value; }

        /// <summary>Creates an new <see cref="AutomationRuleAction" /> instance.</summary>
        public AutomationRuleAction()
        {

        }
    }
    /// Describes an automation rule action
    public partial interface IAutomationRuleAction :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The type of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of the automation rule action",
        SerializedName = @"actionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType ActionType { get; set; }
        /// <summary>The order of execution of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The order of execution of the automation rule action",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(int) })]
        int Order { get; set; }

    }
    /// Describes an automation rule action
    internal partial interface IAutomationRuleActionInternal

    {
        /// <summary>The type of the automation rule action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType ActionType { get; set; }
        /// <summary>The order of execution of the automation rule action</summary>
        int Order { get; set; }

    }
}