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

using Microsoft.Azure.Commands.OperationalInsights.Models;
using Microsoft.Azure.Commands.OperationalInsights.Properties;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.OperationalInsights
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "OperationalInsightsLinuxSyslogDataSource", SupportsShouldProcess = true, DefaultParameterSetName = ByWorkspaceName), OutputType(typeof(PSDataSource))]
    public class NewAzureOperationalInsightsLinuxSyslogDataSourceCommand : NewAzureOperationalInsightsDataSourceBaseCmdlet
    {
        [Parameter(Position = 0, ParameterSetName = ByWorkspaceObject, Mandatory = true, ValueFromPipeline = true,
            HelpMessage = "The workspace that will contain the data source.")]
        [ValidateNotNull]
        public override PSWorkspace Workspace { get; set; }

        [Parameter(Position = 1, ParameterSetName = ByWorkspaceName, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public override string ResourceGroupName { get; set; }

        [Parameter(Position = 2, ParameterSetName = ByWorkspaceName, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The name of the workspace that will contain the data source.")]
        [ValidateNotNullOrEmpty]
        public override string WorkspaceName { get; set; }

        [Parameter(Position = 3, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The data source name.")]
        [ValidateNotNullOrEmpty]
        public override string Name { get; set; }

        [Parameter(Position = 4, Mandatory = true, ValueFromPipelineByPropertyName = true,
        HelpMessage = "The name of Linux Syslog.")]
        [ValidateNotNullOrEmpty]
        public string Facility { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect emerg log type.")]
        public SwitchParameter CollectEmergency { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect alert log type.")]
        public SwitchParameter CollectAlert { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect crit log type.")]
        public SwitchParameter CollectCritical { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect err log type.")]
        public SwitchParameter CollectError { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect warning log type.")]
        public SwitchParameter CollectWarning { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect notice log type.")]
        public SwitchParameter CollectNotice { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect debug log type.")]
        public SwitchParameter CollectDebug { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Collect informational log type.")]
        public SwitchParameter CollectInformational { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Don't ask for confirmation.")]
        public override SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            List<SyslogSeverityIdentifier> severitySubscription = new List<SyslogSeverityIdentifier>();
            if (CollectEmergency.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.emerg }); }
            if (CollectAlert.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.alert }); }
            if (CollectCritical.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.crit }); }
            if (CollectError.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.err }); }
            if (CollectWarning.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.warning }); }
            if (CollectNotice.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.notice }); }
            if (CollectDebug.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.debug }); }
            if (CollectInformational.IsPresent) { severitySubscription.Add(new SyslogSeverityIdentifier { Severity = SyslogSeverities.info }); }

            if (severitySubscription.Count == 0) {
                throw new PSArgumentException(Resources.DataSourceSyslogNoSeveritySelected);
            }

            var dsProperties = new PSLinuxSyslogDataSourceProperties
            {
                SyslogName = this.Facility,
                SyslogSeverities = severitySubscription
            };

            CreatePSDataSourceWithProperties(dsProperties);
        }
    }
}
