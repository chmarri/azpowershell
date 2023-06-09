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
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.Compute
{
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VM",SupportsShouldProcess = true,DefaultParameterSetName = ResourceGroupNameParameterSet)]
    [OutputType(typeof(PSComputeLongRunningOperation), typeof(PSAzureOperationResponse))]
    public class RemoveAzureVMCommand : VirtualMachineActionBaseCmdlet
    {
        [Alias("ResourceName", "VMName")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = ResourceGroupNameParameterSet,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachines", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            HelpMessage = "Optional parameter to force delete a VM.")]
        public bool? ForceDeletion { get; set; }

        [Parameter(
            Position = 2,
            HelpMessage = "To force the removal.")]
        [ValidateNotNullOrEmpty]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Starts the operation and returns immediately, before the operation is completed. In order to determine if the operation has successfully been completed, use some other mechanism.")]
        public SwitchParameter NoWait { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            bool? forcedelete = ForceDeletion.HasValue ? ForceDeletion.Value : (bool?)null;
            ExecuteClientAction(() =>
            {
                if (!string.IsNullOrEmpty(Id) && string.IsNullOrEmpty(Name))
                {
                    ResourceIdentifier parsedId = new ResourceIdentifier(Id);
                    this.ResourceGroupName = parsedId.ResourceGroupName;
                    this.Name = parsedId.ResourceName;
                }

                if (this.ShouldProcess(Name, VerbsCommon.Remove)
                    && (this.Force.IsPresent || 
                        this.ShouldContinue(Properties.Resources.VirtualMachineRemovalConfirmation, 
                        Properties.Resources.VirtualMachineRemovalCaption)))
                {
                    if (NoWait.IsPresent)
                    {
                        var op = this.VirtualMachineClient.BeginDeleteWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            this.Name, forceDeletion:forcedelete).GetAwaiter().GetResult();
                        var result = ComputeAutoMapperProfile.Mapper.Map<PSAzureOperationResponse>(op);
                        WriteObject(result);
                    }
                    else
                    {
                        var op = this.VirtualMachineClient.DeleteWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            this.Name, forceDeletion:forcedelete).GetAwaiter().GetResult();
                        var result = ComputeAutoMapperProfile.Mapper.Map<PSComputeLongRunningOperation>(op);
                        result.StartTime = this.StartTime;
                        result.EndTime = DateTime.Now;
                        WriteObject(result);
                    }
                }
            });
        }
    }
}
