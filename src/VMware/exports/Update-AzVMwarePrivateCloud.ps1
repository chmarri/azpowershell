
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
Update a private cloud
.Description
Update a private cloud
.Example
Update-AzVMwarePrivateCloud -Name azps_test_cloud -ResourceGroupName azps_test_group -ManagementClusterSize 4
.Example
Get-AzVMwarePrivateCloud -ResourceGroupName azps_test_group -Name azps_test_cloud | Update-AzVMwarePrivateCloud -ManagementClusterSize 4

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IPrivateCloud
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

IDENTITYSOURCE <IIdentitySource[]>: vCenter Single Sign On Identity Sources
  [Alias <String>]: The domain's NetBIOS name
  [BaseGroupDn <String>]: The base distinguished name for groups
  [BaseUserDn <String>]: The base distinguished name for users
  [Domain <String>]: The domain's dns name
  [Name <String>]: The name of the identity source
  [Password <String>]: The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups.
  [PrimaryServer <String>]: Primary server URL
  [SecondaryServer <String>]: Secondary server URL
  [Ssl <SslEnum?>]: Protect LDAP communication using SSL certificate (LDAPS)
  [Username <String>]: The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PlacementPolicyName <String>]: Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://learn.microsoft.com/powershell/module/az.vmware/update-azvmwareprivatecloud
#>
function Update-AzVMwarePrivateCloud {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IPrivateCloud])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('PrivateCloudName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The secondary availability zone for the private cloud
    ${AvailabilitySecondaryZone},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AvailabilityStrategy])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AvailabilityStrategy]
    # The availability strategy for the private cloud
    ${AvailabilityStrategy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The primary availability zone for the private cloud
    ${AvailabilityZone},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState]
    # Status of customer managed encryption key
    ${EncryptionStatus},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IIdentitySource[]]
    # vCenter Single Sign On Identity Sources
    # To construct, see NOTES section for IDENTITYSOURCE properties and create a hash table.
    ${IdentitySource},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ResourceIdentityType]
    # The type of identity used for the private cloud.
    # The type 'SystemAssigned' refers to an implicitly created identity.
    # The type 'None' will remove any identities from the Private Cloud.
    ${IdentityType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum]
    # Connectivity to internet is enabled or disabled
    ${Internet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The name of the key.
    ${KeyVaultPropertyKeyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The URL of the vault.
    ${KeyVaultPropertyKeyVaultUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The version of the key.
    ${KeyVaultPropertyKeyVersion},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String[]]
    # The hosts
    ${ManagementClusterHost},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The cluster size
    ${ManagementClusterSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
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

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.VMware.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.VMware.private\Update-AzVMwarePrivateCloud_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.VMware.private\Update-AzVMwarePrivateCloud_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.VMware.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
