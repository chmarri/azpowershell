
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Update the vm details that will be monitored by the Elastic monitor resource.
.Description
Update the vm details that will be monitored by the Elastic monitor resource.
.Example
PS C:\> Update-AzElasticVMCollection -ResourceGroupName lucas-elastic-test -Name elastic-pwsh02 -OperationName Add -VMResourceId '/subscriptions/xxxxxxxx-xxxxx-xxxx-xxxx-xxxxxxxx/resourceGroups/VIDHI-RG/providers/Microsoft.Compute/virtualMachines/vidhi-linuxOS'

.Example
PS C:\> Get-AzElasticMonitor -ResourceGroupName lucas-elastic-test -Name elastic-pwsh02 | Update-AzElasticVMCollection -OperationName Delete -VMResourceId '/subscriptions/xxxxxxxx-xxxxx-xxxx-xxxx-xxxxxxxx/resourceGroups/VIDHI-RG/providers/Microsoft.Compute/virtualMachines/vidhi-linuxOS'


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IElasticIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [MonitorName <String>]: Monitor resource name
  [ResourceGroupName <String>]: The name of the resource group to which the Elastic resource belongs.
  [RuleSetName <String>]: Tag Rule Set resource name
  [SubscriptionId <String>]: The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000)
.Link
https://learn.microsoft.com/powershell/module/az.elastic/update-azelasticvmcollection
#>
function Update-AzElasticVMCollection {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Path')]
    [System.String]
    # Monitor resource name
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Path')]
    [System.String]
    # The name of the resource group to which the Elastic resource belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000)
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.OperationName])]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.OperationName]
    # Operation to be performed for given VM.
    ${OperationName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Body')]
    [System.String]
    # ARM id of the VM resource.
    ${VMResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.Elastic.private\Update-AzElasticVMCollection_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.Elastic.private\Update-AzElasticVMCollection_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
