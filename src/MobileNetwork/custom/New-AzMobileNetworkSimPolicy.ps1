
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
Creates or updates a SIM policy.
Must be created in the same location as its parent mobile network.
.Description
Creates or updates a SIM policy.
Must be created in the same location as its parent mobile network.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicy
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

SLICECONFIGURATION <ISliceConfiguration[]>: The allowed slices and the settings to use for them. The list must not contain duplicate items and must contain at least one item.
  DataNetworkConfiguration <IDataNetworkConfiguration[]>: The allowed data networks and the settings to use for them. The list must not contain duplicate items and must contain at least one item.
    AllowedService <IServiceResourceId[]>: List of services that can be used as part of this SIM policy. The list must not contain duplicate items and must contain at least one item. The services must be in the same location as the SIM policy.
      Id <String>: Service resource ID.
    DataNetworkId <String>: Data network resource ID.
    SessionAmbrDownlink <String>: Downlink bit rate.
    SessionAmbrUplink <String>: Uplink bit rate.
    [AdditionalAllowedSessionType <PduSessionType[]>]: Allowed session types in addition to the default session type. Must not duplicate the default session type.
    [AllocationAndRetentionPriorityLevel <Int32?>]: Default QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
    [DefaultSessionType <PduSessionType?>]: The default PDU session type, which is used if the UE does not request a specific session type.
    [FiveQi <Int32?>]: Default QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
    [MaximumNumberOfBufferedPacket <Int32?>]: The maximum number of downlink packets to buffer at the user plane for High Latency Communication - Extended Buffering. See 3GPP TS29.272 v15.10.0 section 7.3.188 for a full description. This maximum is not guaranteed because there is a internal limit on buffered packets across all PDU sessions.
    [PreemptionCapability <PreemptionCapability?>]: Default QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
    [PreemptionVulnerability <PreemptionVulnerability?>]: Default QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
  DefaultDataNetworkId <String>: Data network resource ID.
  SlouseId <String>: Slice resource ID.
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/new-azmobilenetworksimpolicy
#>
function New-AzMobileNetworkSimPolicy {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicy])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the mobile network.
    ${MobileNetworkName},

    [Parameter(Mandatory)]
    [Alias('SimPolicyName')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the SIM policy.
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
    # Slice resource ID.
    ${DefaultSliceId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(Mandatory)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISliceConfiguration[]]
    # The allowed slices and the settings to use for them.
    # The list must not contain duplicate items and must contain at least one item.
    # To construct, see NOTES section for SLICECONFIGURATION properties and create a hash table.
    ${SliceConfiguration},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Downlink bit rate.
    ${UeAmbrDownlink},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Uplink bit rate.
    ${UeAmbrUplink},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.Int32]
    # Interval for the UE periodic registration update procedure, in seconds.
    ${RegistrationTimer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.Int32]
    # RAT/Frequency Selection Priority Index, defined in 3GPP TS 36.413.
    # This is an optional setting and by default is unspecified.
    ${RfspIndex},

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
                $dataBase = Get-AzMobileNetworkSimPolicy -MobileNetworkName $PSBoundParameters.MobileNetworkName -ResourceGroupName $PSBoundParameters.ResourceGroupName -Name $PSBoundParameters.Name
            }
            catch{
                return Az.MobileNetwork.internal\New-AzMobileNetworkSimPolicy @PSBoundParameters
            }

            if($dataBase.Count -le 0){
                return Az.MobileNetwork.internal\New-AzMobileNetworkSimPolicy @PSBoundParameters
            }

            if (!$PSBoundParameters.ContainsKey('EncryptionKeyUrl')) {
                $PSBoundParameters.EncryptionKeyUrl = $dataBase.EncryptionKeyUrl
            }
            if (!$PSBoundParameters.ContainsKey('IdentityType')) {
                $PSBoundParameters.IdentityType = $dataBase.IdentityType
            }
            if (!$PSBoundParameters.ContainsKey('IdentityUserAssignedIdentity')) {
                $PSBoundParameters.IdentityUserAssignedIdentity = $dataBase.IdentityUserAssignedIdentity
            }
            if (!$PSBoundParame8ters.ContainsKey('MobileNetworkId')) {
                $PSBoundParameters.MobileNetworkId = $dataBase.MobileNetworkId
            }

            return Az.MobileNetwork.internal\New-AzMobileNetworkSimPolicy @PSBoundParameters
        }
        catch {
            throw
        }
    }
}
