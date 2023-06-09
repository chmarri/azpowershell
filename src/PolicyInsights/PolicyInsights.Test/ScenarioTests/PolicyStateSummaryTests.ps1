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

<#
.SYNOPSIS
Get policy states summary at management group scope
#>
function Get-AzureRmPolicyStateSummary-ManagementGroupScope {
	$managementGroupName = Get-TestManagementGroupName
	$from = Get-TestQueryIntervalStart

	$policyStateSummary = Get-AzPolicyStateSummary -ManagementGroupName $managementGroupName -Top 10 -From $from
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at subscription scope
#>
function Get-AzureRmPolicyStateSummary-SubscriptionScope {
	$from = Get-TestQueryIntervalStart

	$policyStateSummary = Get-AzPolicyStateSummary -Top 10 -From $from
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at resource group scope
#>
function Get-AzureRmPolicyStateSummary-ResourceGroupScope {
	$resourceGroupName = Get-FirstTestResourceGroupName
	$from = Get-TestQueryIntervalStart

	$policyStateSummary = Get-AzPolicyStateSummary -ResourceGroupName $resourceGroupName -Top 10 -From $from
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at resource scope
#>
function Get-AzureRmPolicyStateSummary-ResourceScope {
	$resourceId = Get-TestResourceId
	$from = Get-TestQueryIntervalStart

	$policyStateSummary = Get-AzPolicyStateSummary -ResourceId $resourceId -Top 10 -From $from
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at policy set definition scope
#>
function Get-AzureRmPolicyStateSummary-PolicySetDefinitionScope {
	$policySetDefinitionName = Get-TestPolicySetDefinitionName

	$policyStateSummary = Get-AzPolicyStateSummary -PolicySetDefinitionName $policySetDefinitionName -Top 10
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at policy definition scope
#>
function Get-AzureRmPolicyStateSummary-PolicyDefinitionScope {
	$policyDefinitionName = Get-TestAuditPolicyDefinitionName

	$policyStateSummary = Get-AzPolicyStateSummary -PolicyDefinitionName $policyDefinitionName -Top 10
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at subscription level policy assignment scope
#>
function Get-AzureRmPolicyStateSummary-SubscriptionLevelPolicyAssignmentScope {
	$policyAssignmentName = Get-TestSubscriptionAuditAssignmentName

	$policyStateSummary = Get-AzPolicyStateSummary -PolicyAssignmentName $policyAssignmentName -Top 10
	Validate-PolicyStateSummary $policyStateSummary
}

<#
.SYNOPSIS
Get policy states summary at resource group level policy assignment scope
#>
function Get-AzureRmPolicyStateSummary-ResourceGroupLevelPolicyAssignmentScope {
	$resourceGroupName = Get-FirstTestResourceGroupName
	$policyAssignmentName = Get-TestResourceGroupAuditAssignmentName

	$policyStateSummary = Get-AzPolicyStateSummary -ResourceGroupName $resourceGroupName -PolicyAssignmentName $policyAssignmentName -Top 10
	Validate-PolicyStateSummary $policyStateSummary
}
