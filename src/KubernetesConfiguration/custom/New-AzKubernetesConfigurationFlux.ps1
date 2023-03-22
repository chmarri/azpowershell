
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
Create a new Kubernetes Flux Configuration.
.Description
Create a new Kubernetes Flux Configuration.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IFluxConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.kubernetesconfiguration/new-azkubernetesconfigurationflux
#>
function New-AzKubernetesConfigurationFlux {
    [Alias('New-AzK8sConfigurationFlux')]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IFluxConfiguration])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the kubernetes cluster.
        ${ClusterName},

        [Parameter(Mandatory)]
        [ValidateSet('ConnectedClusters', 'ManagedClusters')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The Kubernetes cluster resource name - i.e.
        # managedClusters, connectedClusters, provisionedClusters.
        ${ClusterType},

        [Parameter(Mandatory)]
        [Alias('FluxConfigurationName')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # Name of the Flux Configuration.
        ${Name},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The account key (shared key) to access the storage account
        ${AzureBlobAccountKey},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The Azure Blob container name to sync from the url endpoint for the flux configuration.
        ${AzureBlobContainerName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets.
        ${AzureBlobLocalAuthRef},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The Shared Access token to access the storage container
        ${AzureBlobSasToken},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The interval at which to re-reconcile the cluster Azure Blob source with the remote.
        ${AzureBlobSyncIntervalInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The maximum time to attempt to reconcile the cluster Azure Blob source with the remote.
        ${AzureBlobTimeoutInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The URL to sync for the flux configuration Azure Blob storage account.
        ${AzureBlobUrl},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Security.SecureString]
        # Plaintext access key used to securely access the S3 bucket
        ${BucketAccessKey},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Specify whether to use insecure communication when puling data from the S3 bucket.
        ${BucketInsecure},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets.
        ${BucketLocalAuthRef},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The bucket name to sync from the url endpoint for the flux configuration.
        ${BucketName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The interval at which to re-reconcile the cluster bucket source with the remote.
        ${BucketSyncIntervalInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The maximum time to attempt to reconcile the cluster bucket source with the remote.
        ${BucketTimeoutInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The URL to sync for the flux configuration S3 bucket.
        ${BucketUrl},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IFluxConfigurationPropertiesConfigurationProtectedSettings]))]
        [System.Collections.Hashtable]
        # Key-value pairs of protected configuration settings for the configuration
        ${ConfigurationProtectedSetting},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Base64-encoded HTTPS certificate authority contents used to access git private git repositories over HTTPS
        ${GitRepositoryHttpsCaCert},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Plaintext HTTPS username used to access private git repositories over HTTPS
        ${GitRepositoryHttpsUser},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets.
        ${GitRepositoryLocalAuthRef},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Base64-encoded known_hosts value containing public SSH keys required to access private git repositories over SSH
        ${GitRepositorySshKnownHost},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The interval at which to re-reconcile the cluster git repository source with the remote.
        ${GitRepositorySyncIntervalInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Int64]
        # The maximum time to attempt to reconcile the cluster git repository source with the remote.
        ${GitRepositoryTimeoutInSecond},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The URL to sync for the flux configuration git repository.
        ${GitRepositoryUrl},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IFluxConfigurationPropertiesKustomizations]))]
        [System.Collections.Hashtable]
        # Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster.
        ${Kustomization},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The client Id for authenticating a Managed Identity.
        ${ManagedIdentityClientId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The namespace to which this configuration is installed to.
        # Maximum of 253 lower case alphanumeric characters, hyphen and period only.
        ${Namespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The git repository branch name to checkout.
        ${RepositoryRefBranch},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The commit SHA to checkout.
        # This value must be combined with the branch name to be valid.
        # This takes precedence over semver.
        ${RepositoryRefCommit},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The semver range used to match against git repository tags.
        # This takes precedence over tag.
        ${RepositoryRefSemver},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The git repository tag name to checkout.
        # This takes precedence over branch.
        ${RepositoryRefTag},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ScopeType])]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ScopeType]
        # Scope at which the operator will be installed.
        ${Scope},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Base64-encoded certificate used to authenticate a Service Principal
        ${ServicePrincipalClientCertificate},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The password for the certificate used to authenticate a Service Principal
        ${ServicePrincipalClientCertificatePassword},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Specifies whether to include x5c header in client claims when acquiring a token to enable subject name / issuer based authentication for the Client Certificate
        ${ServicePrincipalClientCertificateSendChain},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The client Id for authenticating a Service Principal.
        ${ServicePrincipalClientId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The client secret for authenticating a Service Principal
        ${ServicePrincipalClientSecret},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The tenant Id for authenticating a Service Principal
        ${ServicePrincipalTenantId},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.SourceKindType])]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.SourceKindType]
        # Source Kind to pull the configuration data from.
        ${SourceKind},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Whether this configuration should suspend its reconciliation of its kustomizations and sources.
        ${Suspend},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if ($ClusterType -eq 'ManagedClusters') {
            $PSBoundParameters.Add('ClusterRp', 'Microsoft.ContainerService')
        }
        elseif ($ClusterType -eq 'ConnectedClusters') {
            $PSBoundParameters.Add('ClusterRp', 'Microsoft.Kubernetes')
        }

        Az.KubernetesConfiguration.internal\New-AzKubernetesConfigurationFlux @PSBoundParameters
    }
}
