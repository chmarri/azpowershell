﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.ServiceFabric.Common;
using Microsoft.Azure.Commands.ServiceFabric.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.Azure.Management.ServiceFabric;

namespace Microsoft.Azure.Commands.ServiceFabric.Commands
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzurePrefix + "ServiceFabricApplication", DefaultParameterSetName = ByResourceGroup, SupportsShouldProcess = true), OutputType(typeof(bool))]
    public class RemoveAzServiceFabricApplication : ProxyResourceCmdletBase
    {
        private const string ByResourceGroup = "ByResourceGroup";
        private const string ByInputObject = "ByInputObject";
        private const string ByResourceId = "ByResourceId";

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = ByResourceGroup, ValueFromPipelineByPropertyName = true,
            HelpMessage = "Specify the name of the resource group.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty()]
        public override string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = ByResourceGroup, ValueFromPipelineByPropertyName = true,
            HelpMessage = "Specify the name of the cluster.")]
        [ResourceNameCompleter("Microsoft.ServiceFabric/clusters", nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty()]
        public override string ClusterName { get; set; }

        [Parameter(Mandatory = true, Position = 2, ParameterSetName = ByResourceGroup, 
            HelpMessage = "Specify the name of the application.")]
        [ValidateNotNullOrEmpty()]
        [Alias("ApplicationName")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ByResourceId, ValueFromPipelineByPropertyName = true,
            HelpMessage = "Arm ResourceId of the application.")]
        [ResourceIdCompleter("Microsoft.ServiceFabric/clusters")]
        [ValidateNotNullOrEmpty]
        public String ResourceId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ByInputObject, ValueFromPipeline = true,
            HelpMessage = "The application resource.")]
        public PSApplication InputObject { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = ByResourceGroup,
            HelpMessage = "Returns True if the command succeeds and False if it fails. By default, this cmdlet does not return any output.")]
        [Parameter(Mandatory = false, ParameterSetName = ByInputObject,
            HelpMessage = "Returns True if the command succeeds and False if it fails. By default, this cmdlet does not return any output.")]
        [Parameter(Mandatory = false, ParameterSetName = ByResourceId,
            HelpMessage = "Returns True if the command succeeds and False if it fails. By default, this cmdlet does not return any output.")]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = ByResourceGroup, HelpMessage = "Remove without prompt.")]
        [Parameter(Mandatory = false, ParameterSetName = ByInputObject, HelpMessage = "Remove without prompt.")]
        [Parameter(Mandatory = false, ParameterSetName = ByResourceId, HelpMessage = "Remove without prompt.")]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            switch (ParameterSetName)
            {
                case ByInputObject:
                    this.ResourceId = InputObject.Id;
                    SetParametersByResourceId();
                    break;
                case ByResourceId:
                    SetParametersByResourceId();
                    break;
                case ByResourceGroup:
                    // intentionally left empty
                    break;
                default:
                    throw new PSArgumentException("Invalid ParameterSetName");
            }

            var resourceMessage = string.Format("Application '{0}' in resource group '{1}', cluster name {2}", this.Name, this.ResourceGroupName, this.ClusterName);
            if (ShouldProcess(target: this.ResourceGroupName, action: string.Format("Remove {0}", resourceMessage)))
            {
                ConfirmAction(Force.IsPresent,
                    "Do you want to remove the application? This will remove all services under this resource",
                    "Removing application.",
                    resourceMessage,
                    () =>
                    {
                        try
                        {
                            this.SFRPClient.Applications.Delete(this.ResourceGroupName, this.ClusterName, this.Name);
                            if (PassThru)
                            {
                                WriteObject(true);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.PrintSdkExceptionDetail(ex);
                            throw;
                        }
                    });
            }
        }

        private void SetParametersByResourceId()
        {
            ResourceIdentifier appRId = new ResourceIdentifier(this.ResourceId);
            this.ResourceGroupName = appRId.ResourceGroupName;
            string subscription = appRId.Subscription;
            ResourceIdentifier clusterRId = new ResourceIdentifier($"/subscriptions/{subscription}/resourceGroups/{this.ResourceGroupName}/providers/Microsoft.ServiceFabric/{appRId.ParentResource}");
            if (!appRId.ResourceType.EndsWith(Constants.applicationProvider)
                || !clusterRId.ResourceType.EndsWith(Constants.clusterProvider))
            {
                throw new PSArgumentException(string.Format("invalid resource id {0}", this.ResourceId));
            }

            this.ClusterName = clusterRId.ResourceName;
            this.Name = appRId.ResourceName;
        }
    }
}
