// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>The configuration of the automation rule condition</summary>
    public partial class AutomationRulePropertyValuesConditionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRulePropertyValuesConditionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRulePropertyValuesConditionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Operator" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedOperator? _operator;

        /// <summary>The operator to use for evaluation the condition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedOperator? Operator { get => this._operator; set => this._operator = value; }

        /// <summary>Backing field for <see cref="PropertyName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedProperty? _propertyName;

        /// <summary>The property to evaluate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedProperty? PropertyName { get => this._propertyName; set => this._propertyName = value; }

        /// <summary>Backing field for <see cref="PropertyValue" /> property.</summary>
        private string[] _propertyValue;

        /// <summary>The values to use for evaluating the condition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] PropertyValue { get => this._propertyValue; set => this._propertyValue = value; }

        /// <summary>
        /// Creates an new <see cref="AutomationRulePropertyValuesConditionProperties" /> instance.
        /// </summary>
        public AutomationRulePropertyValuesConditionProperties()
        {

        }
    }
    /// The configuration of the automation rule condition
    public partial interface IAutomationRulePropertyValuesConditionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The operator to use for evaluation the condition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operator to use for evaluation the condition",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedOperator) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedOperator? Operator { get; set; }
        /// <summary>The property to evaluate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The property to evaluate",
        SerializedName = @"propertyName",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedProperty) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedProperty? PropertyName { get; set; }
        /// <summary>The values to use for evaluating the condition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The values to use for evaluating the condition",
        SerializedName = @"propertyValues",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyValue { get; set; }

    }
    /// The configuration of the automation rule condition
    internal partial interface IAutomationRulePropertyValuesConditionPropertiesInternal

    {
        /// <summary>The operator to use for evaluation the condition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedOperator? Operator { get; set; }
        /// <summary>The property to evaluate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRulePropertyConditionSupportedProperty? PropertyName { get; set; }
        /// <summary>The values to use for evaluating the condition</summary>
        string[] PropertyValue { get; set; }

    }
}