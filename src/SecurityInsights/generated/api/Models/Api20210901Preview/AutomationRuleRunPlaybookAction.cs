// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Describes an automation rule action to run a playbook</summary>
    public partial class AutomationRuleRunPlaybookAction :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookAction,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleAction"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleAction __automationRuleAction = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleAction();

        /// <summary>Backing field for <see cref="ActionConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfiguration _actionConfiguration;

        /// <summary>The configuration of the run playbook automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfiguration ActionConfiguration { get => (this._actionConfiguration = this._actionConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleRunPlaybookActionConfiguration()); set => this._actionConfiguration = value; }

        /// <summary>The resource id of the playbook resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string ActionConfigurationLogicAppResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfigurationInternal)ActionConfiguration).LogicAppResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfigurationInternal)ActionConfiguration).LogicAppResourceId = value ?? null; }

        /// <summary>The tenant id of the playbook resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string ActionConfigurationTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfigurationInternal)ActionConfiguration).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfigurationInternal)ActionConfiguration).TenantId = value ?? null; }

        /// <summary>The type of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType ActionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)__automationRuleAction).ActionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)__automationRuleAction).ActionType = value ; }

        /// <summary>Internal Acessors for ActionConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfiguration Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionInternal.ActionConfiguration { get => (this._actionConfiguration = this._actionConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleRunPlaybookActionConfiguration()); set { {_actionConfiguration = value;} } }

        /// <summary>The order of execution of the automation rule action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public int Order { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)__automationRuleAction).Order; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)__automationRuleAction).Order = value ; }

        /// <summary>Creates an new <see cref="AutomationRuleRunPlaybookAction" /> instance.</summary>
        public AutomationRuleRunPlaybookAction()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__automationRuleAction), __automationRuleAction);
            await eventListener.AssertObjectIsValid(nameof(__automationRuleAction), __automationRuleAction);
        }
    }
    /// Describes an automation rule action to run a playbook
    public partial interface IAutomationRuleRunPlaybookAction :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleAction
    {
        /// <summary>The resource id of the playbook resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the playbook resource",
        SerializedName = @"logicAppResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ActionConfigurationLogicAppResourceId { get; set; }
        /// <summary>The tenant id of the playbook resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant id of the playbook resource",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ActionConfigurationTenantId { get; set; }

    }
    /// Describes an automation rule action to run a playbook
    internal partial interface IAutomationRuleRunPlaybookActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal
    {
        /// <summary>The configuration of the run playbook automation rule action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleRunPlaybookActionConfiguration ActionConfiguration { get; set; }
        /// <summary>The resource id of the playbook resource</summary>
        string ActionConfigurationLogicAppResourceId { get; set; }
        /// <summary>The tenant id of the playbook resource</summary>
        string ActionConfigurationTenantId { get; set; }

    }
}