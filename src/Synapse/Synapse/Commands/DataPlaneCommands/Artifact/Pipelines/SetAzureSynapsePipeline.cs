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

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.Pipeline,
        DefaultParameterSetName = SetByName, SupportsShouldProcess = true)]
    [Alias("New-" + ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.Pipeline)]
    [OutputType(typeof(PSPipelineResource))]
    public class SetAzureSynapsePipeline : SynapseArtifactsCmdletBase
    {
        private const string SetByName = "SetByName";
        private const string SetByObject = "SetByObject";

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = SetByName,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public override string WorkspaceName { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = SetByObject,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace WorkspaceObject { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = HelpMessages.PipelineName)]
        [ValidateNotNullOrEmpty]
        [Alias("PipelineName")]
        public string Name { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = HelpMessages.JsonFilePath)]
        [ValidateNotNullOrEmpty]
        [Alias("File")]
        public string DefinitionFile { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJob)]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.WorkspaceObject))
            {
                this.WorkspaceName = this.WorkspaceObject.Name;
            }

            if (this.ShouldProcess(this.WorkspaceName, String.Format(Resources.SettingSynapsePipeline, this.Name, this.WorkspaceName)))
            {
                string rawJsonContent = SynapseAnalyticsClient.ReadJsonFileContent(this.TryResolvePath(DefinitionFile));
                WriteObject(new PSPipelineResource(SynapseAnalyticsClient.CreateOrUpdatePipeline(this.Name, rawJsonContent), this.WorkspaceName));
            }
        }
    }
}
