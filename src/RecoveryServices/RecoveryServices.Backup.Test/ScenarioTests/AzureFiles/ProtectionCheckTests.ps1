﻿# ----------------------------------------------------------------------------------
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

$location = "southeastasia"
$resourceGroupName = "pstestrg8895"
$vaultName = "pstestrsv8895"
$fileShareFriendlyName = "fs1"
$fileShareName = "AzureFileShare;fs1"
$saName = "pstestsa8895"
$skuName="Standard_LRS"
$policyName = "afspolicy1"
$storageAccountId = "/subscriptions/38304e13-357e-405e-9e9a-220351dcce8c/resourceGroups/pstestrg8895/providers/Microsoft.Storage/storageAccounts/pstestsa8895"

# Setup Instructions:
# 1. Create a resource group
# New-AzResourceGroup -Name $resourceGroupName -Location $location

# 2. Create a storage account and a recovery services vault
# New-AzStorageAccount -ResourceGroupName $resourceGroupName -Name $saName -Location $location -SkuName $skuName
# New-AzRecoveryServicesVault -Name $vaultName -ResourceGroupName $resourceGroupName -Location $Location

# 3. Create a file share in the storage account
# $storageAcct = Get-AzStorageAccount -ResourceGroupName $resourceGroupName -Name $saName
# New-AzureStorageShare -Name $fileShareFriendlyName -Context $storageAcct.Context

# 4. Create a backup policy for file shares
# $vault = Get-AzRecoveryServicesVault -ResourceGroupName $resourceGroupName -Name $vaultName
# $schedulePolicy = Get-AzRecoveryServicesBackupSchedulePolicyObject -WorkloadType AzureFiles
# $retentionPolicy = Get-AzRecoveryServicesBackupRetentionPolicyObject -WorkloadType AzureFiles
# $policy = New-AzRecoveryServicesBackupProtectionPolicy -VaultId $vault.ID `
#		-Name $policyName `
#		-WorkloadType AzureFiles `
#		-RetentionPolicy $retentionPolicy `
#		-SchedulePolicy $schedulePolicy

function Test-AzureFSProtectionCheck
{
	try
	{
  $status = Get-AzRecoveryServicesBackupStatus `
			-ResourceId $storageAccountId `
			-ProtectableObjectName $fileShareFriendlyName `
			-Type AzureFiles

		Assert-NotNull $status
		Assert-False { $status.BackedUp }

		$vault = Get-AzRecoveryServicesVault -ResourceGroupName $resourceGroupName -Name $vaultName
		$item = Enable-Protection $vault $fileShareFriendlyName $saName
		
		$status = Get-AzRecoveryServicesBackupStatus `
			-ResourceId $storageAccountId `
			-ProtectableObjectName $fileShareFriendlyName `
			-Type AzureFiles

		Assert-NotNull $status
		Assert-True { $status.BackedUp }
		Assert-True { $status.VaultId -eq $vault.ID }

		$container = Get-AzRecoveryServicesBackupContainer `
			-VaultId $vault.ID `
			-ContainerType AzureStorage `
			-FriendlyName $saName
	}
	finally
	{
		Cleanup-Vault $vault $item $container
	}
}