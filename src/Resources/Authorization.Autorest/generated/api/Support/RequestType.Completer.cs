// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support
{

    /// <summary>
    /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestTypeTypeConverter))]
    public partial struct RequestType :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AdminAssign".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AdminAssign'", "AdminAssign", global::System.Management.Automation.CompletionResultType.ParameterValue, "AdminAssign");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AdminRemove".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AdminRemove'", "AdminRemove", global::System.Management.Automation.CompletionResultType.ParameterValue, "AdminRemove");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AdminUpdate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AdminUpdate'", "AdminUpdate", global::System.Management.Automation.CompletionResultType.ParameterValue, "AdminUpdate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AdminExtend".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AdminExtend'", "AdminExtend", global::System.Management.Automation.CompletionResultType.ParameterValue, "AdminExtend");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AdminRenew".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AdminRenew'", "AdminRenew", global::System.Management.Automation.CompletionResultType.ParameterValue, "AdminRenew");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SelfActivate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SelfActivate'", "SelfActivate", global::System.Management.Automation.CompletionResultType.ParameterValue, "SelfActivate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SelfDeactivate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SelfDeactivate'", "SelfDeactivate", global::System.Management.Automation.CompletionResultType.ParameterValue, "SelfDeactivate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SelfExtend".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SelfExtend'", "SelfExtend", global::System.Management.Automation.CompletionResultType.ParameterValue, "SelfExtend");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SelfRenew".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SelfRenew'", "SelfRenew", global::System.Management.Automation.CompletionResultType.ParameterValue, "SelfRenew");
            }
        }
    }
}