// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The data source that enriched by ueba.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.UebaDataSourcesTypeConverter))]
    public partial struct UebaDataSources :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AuditLogs".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AuditLogs'", "AuditLogs", global::System.Management.Automation.CompletionResultType.ParameterValue, "AuditLogs");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AzureActivity".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AzureActivity'", "AzureActivity", global::System.Management.Automation.CompletionResultType.ParameterValue, "AzureActivity");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityEvent".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SecurityEvent'", "SecurityEvent", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityEvent");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SigninLogs".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SigninLogs'", "SigninLogs", global::System.Management.Automation.CompletionResultType.ParameterValue, "SigninLogs");
            }
        }
    }
}