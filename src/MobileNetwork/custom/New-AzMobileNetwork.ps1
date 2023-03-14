
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
Creates or updates a mobile network.
.Description
Creates or updates a mobile network.
.Example
New-AzMobileNetwork -Name azps-mn -ResourceGroupName azps_test_group -Location eastus -PublicLandMobileNetworkIdentifierMcc 001 -PublicLandMobileNetworkIdentifierMnc 01 -Tag @{"china"="move"}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/new-azmobilenetwork
#>
function New-AzMobileNetwork {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('MobileNetworkName')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the mobile network.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Mobile country code (MCC).
    ${PublicLandMobileNetworkIdentifierMcc},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Mobile network code (MNC).
    ${PublicLandMobileNetworkIdentifierMnc},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        try {
            try{
                $dataBase = Get-AzMobileNetwork -ResourceGroupName $PSBoundParameters.ResourceGroupName -Name $PSBoundParameters.Name
            }
            catch{
                return Az.MobileNetwork.internal\New-AzMobileNetwork @PSBoundParameters
            }

            if($dataBase.Count -le 0){
                return Az.MobileNetwork.internal\New-AzMobileNetwork @PSBoundParameters
            }

            if (!$PSBoundParameters.ContainsKey('PublicLandMobileNetworkIdentifierMcc')) {
                $PSBoundParameters.PublicLandMobileNetworkIdentifierMcc = $dataBase.PublicLandMobileNetworkIdentifierMcc
            }
            if (!$PSBoundParameters.ContainsKey('PublicLandMobileNetworkIdentifierMnc')) {
                $PSBoundParameters.PublicLandMobileNetworkIdentifierMnc = $dataBase.PublicLandMobileNetworkIdentifierMnc
            }

            return Az.MobileNetwork.internal\New-AzMobileNetwork @PSBoundParameters
        }
        catch {
            throw
        }
    }
}
