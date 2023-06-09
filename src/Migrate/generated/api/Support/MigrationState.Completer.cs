// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The migration status.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationStateTypeConverter))]
    public partial struct MigrationState :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'None'", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnableMigrationInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'EnableMigrationInProgress'", "EnableMigrationInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnableMigrationInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnableMigrationFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'EnableMigrationFailed'", "EnableMigrationFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnableMigrationFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisableMigrationInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DisableMigrationInProgress'", "DisableMigrationInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisableMigrationInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisableMigrationFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DisableMigrationFailed'", "DisableMigrationFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisableMigrationFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InitialSeedingInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InitialSeedingInProgress'", "InitialSeedingInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "InitialSeedingInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InitialSeedingFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InitialSeedingFailed'", "InitialSeedingFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "InitialSeedingFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Replicating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Replicating'", "Replicating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Replicating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MigrationInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MigrationInProgress'", "MigrationInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "MigrationInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MigrationSucceeded".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MigrationSucceeded'", "MigrationSucceeded", global::System.Management.Automation.CompletionResultType.ParameterValue, "MigrationSucceeded");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MigrationFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MigrationFailed'", "MigrationFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "MigrationFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResumeInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ResumeInProgress'", "ResumeInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResumeInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResumeInitiated".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ResumeInitiated'", "ResumeInitiated", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResumeInitiated");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SuspendingProtection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SuspendingProtection'", "SuspendingProtection", global::System.Management.Automation.CompletionResultType.ParameterValue, "SuspendingProtection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ProtectionSuspended".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ProtectionSuspended'", "ProtectionSuspended", global::System.Management.Automation.CompletionResultType.ParameterValue, "ProtectionSuspended");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MigrationCompletedWithInformation".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MigrationCompletedWithInformation'", "MigrationCompletedWithInformation", global::System.Management.Automation.CompletionResultType.ParameterValue, "MigrationCompletedWithInformation");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MigrationPartiallySucceeded".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MigrationPartiallySucceeded'", "MigrationPartiallySucceeded", global::System.Management.Automation.CompletionResultType.ParameterValue, "MigrationPartiallySucceeded");
            }
        }
    }
}