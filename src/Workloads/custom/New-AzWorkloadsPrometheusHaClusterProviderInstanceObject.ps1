
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
Create an in-memory object for PrometheusHaClusterProviderInstanceProperties.
.Description
Create an in-memory object for PrometheusHaClusterProviderInstanceProperties.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.PrometheusHaClusterProviderInstanceProperties
.Link
https://learn.microsoft.com/powershell/module/az./new-AzWorkloadsPrometheusHaClusterProviderInstanceObject
#>
function New-AzWorkloadsPrometheusHaClusterProviderInstanceObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.PrometheusHaClusterProviderInstanceProperties')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Gets or sets the clusterName.")]
        [string]
        $ClusterName,
        [Parameter(HelpMessage="Gets or sets the target machine name.")]
        [string]
        $Hostname,
        [Parameter(HelpMessage="URL of the Node Exporter endpoint.")]
        [string]
        $PrometheusUrl,
        [Parameter(HelpMessage="Gets or sets the cluster sid.")]
        [string]
        $Sid,
        [Parameter(HelpMessage="Gets or sets the blob URI to SSL certificate for the HA cluster exporter.")]
        [string]
        $SslCertificateUri,
        [Parameter(HelpMessage="Gets or sets certificate preference if secure communication is enabled.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference])]
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference]
        $SslPreference
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.PrometheusHaClusterProviderInstanceProperties]::New()

        if ($PSBoundParameters.ContainsKey('ClusterName')) {
            $Object.ClusterName = $ClusterName
        }
        if ($PSBoundParameters.ContainsKey('Hostname')) {
            $Object.Hostname = $Hostname
        }
        if ($PSBoundParameters.ContainsKey('PrometheusUrl')) {
            $Object.PrometheusUrl = $PrometheusUrl
        }
        if ($PSBoundParameters.ContainsKey('Sid')) {
            $Object.Sid = $Sid
        }
        if ($PSBoundParameters.ContainsKey('SslCertificateUri')) {
            $Object.SslCertificateUri = $SslCertificateUri
        }
        $Object.ProviderType = 'PrometheusHaCluster'
        return $Object
    }
}

