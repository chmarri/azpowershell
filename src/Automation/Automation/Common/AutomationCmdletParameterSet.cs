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


namespace Microsoft.Azure.Commands.Automation.Common
{
    internal static class AutomationCmdletParameterSets
    {
        /// <summary>
        /// By All parameter set.
        /// </summary>
        internal const string ByAll = "ByAll";

        /// <summary>
        /// By Name parameter set.
        /// </summary>
        internal const string ByName = "ByName";

        /// <summary>
        /// By Path parameter set.
        /// </summary>
        internal const string ByPath = "ByPath";

        /// <summary>
        /// By Id parameter set
        /// </summary>
        internal const string ById = "ById";

        /// <summary>
        /// The one time schedule parameter set.
        /// </summary>
        internal const string ByOneTime = "ByOneTime";

        /// <summary>
        /// The daily schedule parameter set.
        /// </summary>
        internal const string ByDaily = "ByDaily";

        /// <summary>
        /// The hourly schedule parameter set.
        /// </summary>
        internal const string ByHourly = "ByHourly";

        /// <summary>
        /// The weekly schedule parameter set.
        /// </summary>
        internal const string ByWeekly = "ByWeekly";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDaysOfMonth = "ByMonthlyDaysOfMonth";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDayOfWeek = "ByMonthlyDayOfWeek";

        /// <summary>
        /// The one time schedule parameter set.
        /// </summary>
        internal const string ByOneTimeWindows = "ByOneTimeWindows";

        /// <summary>
        /// The daily schedule parameter set.
        /// </summary>
        internal const string ByDailyWindows = "ByDailyWindows";

        /// <summary>
        /// The hourly schedule parameter set.
        /// </summary>
        internal const string ByHourlyWindows = "ByHourlyWindows";

        /// <summary>
        /// The weekly schedule parameter set.
        /// </summary>
        internal const string ByWeeklyWindows = "ByWeeklyWindows";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDaysOfMonthWindows = "ByMonthlyDaysOfMonthWindows";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDayOfWeekWindows = "ByMonthlyDayOfWeekWindows";
        
        /// <summary>
        /// The one time schedule parameter set.
        /// </summary>
        internal const string ByOneTimeLinux = "ByOneTimeLinux";

        /// <summary>
        /// The daily schedule parameter set.
        /// </summary>
        internal const string ByDailyLinux = "ByDailyLinux";

        /// <summary>
        /// The hourly schedule parameter set.
        /// </summary>
        internal const string ByHourlyLinux = "ByHourlyLinux";

        /// <summary>
        /// The weekly schedule parameter set.
        /// </summary>
        internal const string ByWeeklyLinux = "ByWeeklyLinux";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDaysOfMonthLinux = "ByMonthlyDaysOfMonthLinux";

        /// <summary>
        /// The monthly schedule parameter set.
        /// </summary>
        internal const string ByMonthlyDayOfWeekLinux = "ByMonthlyDayOfWeekLinux";

        /// <summary>
        /// The Job Id parameter set.
        /// </summary>
        internal const string ByJobId = "ByJobId";

        /// <summary>
        /// By Latest parameter set
        /// </summary>
        internal const string ByLatest = "ByLatest";

        /// <summary>
        /// The automation account name parameter set.
        /// </summary>
        internal const string ByAutomationAccountName = "ByAutomationAccountName";

        /// <summary>
        /// The Runbook name parameter set.
        /// </summary>
        internal const string ByRunbookName = "ByRunbookName";

        /// <summary>
        /// The ByAsynchronousReturnJob.
        /// </summary>
        internal const string ByAsynchronousReturnJob = "ByAsynchronousReturnJob";

        /// <summary>
        /// The BySynchronousReturnJob.
        /// </summary>
        internal const string BySynchronousReturnJobOutput = "BySynchronousReturnJobOutput";

        /// <summary>
        /// The Configuration name parameter set.
        /// </summary>
        internal const string ByConfigurationName = "ByConfigurationName";

        /// <summary>
        /// The Configuration name parameter set.
        /// </summary>
        internal const string ByConfiguration = "ByConfiguration";

        /// <summary>
        /// The Node Configuration name parameter set.
        /// </summary>
        internal const string ByNodeConfigurationName = "ByNodeConfigurationName";

        /// <summary>
        /// The Schedule name parameter set.
        /// </summary>
        internal const string ByScheduleName = "ByScheduleName";

        /// <summary>
        /// The certificate name parameter set.
        /// </summary>
        internal const string ByCertificateName = "ByCertificateName";

        /// <summary>
        /// The connection name parameter set.
        /// </summary>
        internal const string ByConnectionName = "ByConnectionName";

        /// <summary>
        /// The connection type name parameter set.
        /// </summary>
        internal const string ByConnectionTypeName = "ByConnectionTypeName";

        /// <summary>
        /// The Schedule name parameter set.
        /// </summary>
        internal const string ByRunbookNameAndScheduleName = "ByRunbookNameAndScheduleName";

        /// <summary>
        /// The Job Schedule Id parameter set.
        /// </summary>
        internal const string ByJobScheduleId = "ByJobScheduleId";

        /// <summary>
        /// Parameter set for updating variable value
        /// </summary>
        internal const string UpdateVariableValue = "UpdateVariableValue";

        /// <summary>
        /// Parameter set for updating variable description
        /// </summary>
        internal const string UpdateVariableDescription = "UpdateVariableDescription";

        /// <summary>
        /// Parameter set for NodeConfiguration
        /// </summary>
        internal const string ByNodeConfiguration = "ByNodeConfiguration";

        /// <summary>
        /// Parameter set for ByNodeConfigurationBuild
        /// </summary>
        internal const string ByNodeConfigurationBuild = "ByNodeConfigurationBuild";

        /// <summary>
        /// Parameter set for ByInputObject
        /// </summary>
        internal const string ByInputObject = "ByInputObject";

        /// <summary>
        /// Parameter set for ByVMId
        /// </summary>
        internal const string ByVMId = "ByVMId";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfiguration Name
        /// </summary>
        internal const string BySucName = "BySucName";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfiguration object
        /// </summary>
        internal const string BySuc = "BySuc";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfigurationRun Id
        /// </summary>
        internal const string BySucrId = "BySucrId";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfigurationRun object
        /// </summary>
        internal const string BySucr = "BySucr";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfiguration targeting windows
        /// </summary>
        internal const string Windows = "Windows";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfiguration targeting Linux
        /// </summary>
        internal const string Linux = "Linux";

        /// <summary>
        /// Parameter set for By SoftwareUpdateConfiguration RebootOnly
        /// </summary>
        internal const string RebootOnly = "RebootOnly";

        /// <summary>
        /// Parameter set for By HybridRunbookWorkerGroupName
        /// </summary>
        internal const string ByHybridRunbookWorkerGroupName = "ByHybridRunbookWorkerGroupName";
    }
}
