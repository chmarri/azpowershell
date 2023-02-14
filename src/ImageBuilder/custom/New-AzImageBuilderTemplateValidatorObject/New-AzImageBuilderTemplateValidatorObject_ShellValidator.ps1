
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ImageTemplateValidator.
.Description
Create an in-memory object for ImageTemplateValidator.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateShellValidator
.Link
https://learn.microsoft.com/powershell/module/az.ImageBuilder/new-azimagebuildertemplatevalidatorobject
#>
function New-AzImageBuilderTemplateValidatorObject_ShellValidator {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateShellValidator')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Array of shell commands to execute.")]
        [string[]]
        $Inline,
        [Parameter(HelpMessage="URI of the shell script to be run for validation. It can be a github link, Azure Storage URI, etc.")]
        [string]
        $ScriptUri,
        [Parameter(HelpMessage="SHA256 checksum of the shell script provided in the scriptUri field.")]
        [string]
        $Sha256Checksum,
        [Parameter(HelpMessage="Friendly Name to provide context on what this validation step does.")]
        [string]
        $Name,
        # Change it to switch parameter
        # [Parameter(Mandatory, HelpMessage="The type of validation you want to use on the Image. For example, `"Shell`" can be shell validation.")]
        # [string]
        # $Type
        [Parameter(Mandatory, HelpMessage="Runs the specified shell script during the validation phase (Linux). Corresponds to Packer shell provisioner. Exactly one of 'scriptUri' or 'inline' can be specified.")]
        [Switch]
        $ShellValidator
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220214.ImageTemplateShellValidator]::New()

        if ($PSBoundParameters.ContainsKey('Inline')) {
            $Object.Inline = $Inline
        }
        if ($PSBoundParameters.ContainsKey('ScriptUri')) {
            $Object.ScriptUri = $ScriptUri
        }
        if ($PSBoundParameters.ContainsKey('Sha256Checksum')) {
            $Object.Sha256Checksum = $Sha256Checksum
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($ShellValidator.IsPresent) {
            $Object.Type = "Shell"
        }
        return $Object
    }
}

