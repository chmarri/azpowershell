// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.Automation.Common;
using Microsoft.Azure.Commands.Automation.Properties;
using System.Management.Automation;
using System.Security.Permissions;

namespace Microsoft.Azure.Commands.Automation.Cmdlet
{
    /// <summary>
    /// Removes a hybridworkergroup for automation.
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AutomationHybridRunbookWorkerGroup",
        SupportsShouldProcess = true)]
    [OutputType(typeof(void))]
    public class RemoveAzureAutomationHybridRunbookWorkerGroup : AzureAutomationBaseCmdlet
    {
        /// <summary>
        /// Gets or sets the hybridworkergroup name.
        /// </summary>
        [Parameter(Position = 2, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The hybrid worker group name.")]
        [ValidateNotNullOrEmpty]
        [Alias("RunbookWorkerGroup", "WorkerGroup")]
        public string Name { get; set; }

        /// <summary>
        /// Execute this cmdlet.
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void AutomationProcessRecord()
        {
            ConfirmAction(
                       string.Format(Resources.RemoveAzureAutomationResourceDescription, "HybridRunbookWorkerGroup"),
                       Name,
                       () =>
                       {
                           this.AutomationClient.DeleteHybridRunbookWorkerGroup(this.ResourceGroupName, this.AutomationAccountName, Name);
                       });
        }
    }
}
