// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Support
{

    /// <summary>SKU of the dedicated HSM</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Support.SkuNameTypeConverter))]
    public partial struct SkuName :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SafeNet Luna Network HSM A790".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SafeNet Luna Network HSM A790'", "SafeNet Luna Network HSM A790", global::System.Management.Automation.CompletionResultType.ParameterValue, "SafeNet Luna Network HSM A790");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK1_CPS60".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK1_CPS60'", "payShield10K_LMK1_CPS60", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK1_CPS60");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK1_CPS250".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK1_CPS250'", "payShield10K_LMK1_CPS250", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK1_CPS250");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK1_CPS2500".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK1_CPS2500'", "payShield10K_LMK1_CPS2500", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK1_CPS2500");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK2_CPS60".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK2_CPS60'", "payShield10K_LMK2_CPS60", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK2_CPS60");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK2_CPS250".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK2_CPS250'", "payShield10K_LMK2_CPS250", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK2_CPS250");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "payShield10K_LMK2_CPS2500".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'payShield10K_LMK2_CPS2500'", "payShield10K_LMK2_CPS2500", global::System.Management.Automation.CompletionResultType.ParameterValue, "payShield10K_LMK2_CPS2500");
            }
        }
    }
}