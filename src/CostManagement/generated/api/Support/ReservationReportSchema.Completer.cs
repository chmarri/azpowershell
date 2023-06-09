// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>
    /// The CSV file from the reportUrl blob link consists of reservation usage data with the following schema at daily granularity
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReservationReportSchemaTypeConverter))]
    public partial struct ReservationReportSchema :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InstanceFlexibilityGroup".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InstanceFlexibilityGroup'", "InstanceFlexibilityGroup", global::System.Management.Automation.CompletionResultType.ParameterValue, "InstanceFlexibilityGroup");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InstanceFlexibilityRatio".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InstanceFlexibilityRatio'", "InstanceFlexibilityRatio", global::System.Management.Automation.CompletionResultType.ParameterValue, "InstanceFlexibilityRatio");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InstanceId".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InstanceId'", "InstanceId", global::System.Management.Automation.CompletionResultType.ParameterValue, "InstanceId");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Kind".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Kind'", "Kind", global::System.Management.Automation.CompletionResultType.ParameterValue, "Kind");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReservationId".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReservationId'", "ReservationId", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReservationId");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReservationOrderId".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReservationOrderId'", "ReservationOrderId", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReservationOrderId");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReservedHours".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReservedHours'", "ReservedHours", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReservedHours");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SkuName".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SkuName'", "SkuName", global::System.Management.Automation.CompletionResultType.ParameterValue, "SkuName");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TotalReservedQuantity".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'TotalReservedQuantity'", "TotalReservedQuantity", global::System.Management.Automation.CompletionResultType.ParameterValue, "TotalReservedQuantity");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UsageDate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UsageDate'", "UsageDate", global::System.Management.Automation.CompletionResultType.ParameterValue, "UsageDate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UsedHours".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UsedHours'", "UsedHours", global::System.Management.Automation.CompletionResultType.ParameterValue, "UsedHours");
            }
        }
    }
}