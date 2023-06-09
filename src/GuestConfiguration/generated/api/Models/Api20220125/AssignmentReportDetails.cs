// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    /// <summary>Details of the guest configuration assignment report.</summary>
    public partial class AssignmentReportDetails :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetails,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal
    {

        /// <summary>Backing field for <see cref="ComplianceStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? _complianceStatus;

        /// <summary>
        /// A value indicating compliance status of the machine for the assigned guest configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? ComplianceStatus { get => this._complianceStatus; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>
        /// End date and time of the guest configuration assignment compliance status check.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        /// <summary>GUID of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; }

        /// <summary>Internal Acessors for ComplianceStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal.ComplianceStatus { get => this._complianceStatus; set { {_complianceStatus = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for JobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal.JobId { get => this._jobId; set { {_jobId = value;} } }

        /// <summary>Internal Acessors for OperationType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal.OperationType { get => this._operationType; set { {_operationType = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportDetailsInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? _operationType;

        /// <summary>Type of report, Consistency or Initial</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get => this._operationType; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource[] _resource;

        /// <summary>
        /// The list of resources for which guest configuration assignment compliance is checked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource[] Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>
        /// Start date and time of the guest configuration assignment compliance status check.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Creates an new <see cref="AssignmentReportDetails" /> instance.</summary>
        public AssignmentReportDetails()
        {

        }
    }
    /// Details of the guest configuration assignment report.
    public partial interface IAssignmentReportDetails :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A value indicating compliance status of the machine for the assigned guest configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating compliance status of the machine for the assigned guest configuration.",
        SerializedName = @"complianceStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? ComplianceStatus { get;  }
        /// <summary>
        /// End date and time of the guest configuration assignment compliance status check.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"End date and time of the guest configuration assignment compliance status check.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>GUID of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"GUID of the report.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get;  }
        /// <summary>Type of report, Consistency or Initial</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of report, Consistency or Initial",
        SerializedName = @"operationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get;  }
        /// <summary>
        /// The list of resources for which guest configuration assignment compliance is checked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of resources for which guest configuration assignment compliance is checked.",
        SerializedName = @"resources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource[] Resource { get; set; }
        /// <summary>
        /// Start date and time of the guest configuration assignment compliance status check.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Start date and time of the guest configuration assignment compliance status check.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }

    }
    /// Details of the guest configuration assignment report.
    internal partial interface IAssignmentReportDetailsInternal

    {
        /// <summary>
        /// A value indicating compliance status of the machine for the assigned guest configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? ComplianceStatus { get; set; }
        /// <summary>
        /// End date and time of the guest configuration assignment compliance status check.
        /// </summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>GUID of the report.</summary>
        string JobId { get; set; }
        /// <summary>Type of report, Consistency or Initial</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get; set; }
        /// <summary>
        /// The list of resources for which guest configuration assignment compliance is checked.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource[] Resource { get; set; }
        /// <summary>
        /// Start date and time of the guest configuration assignment compliance status check.
        /// </summary>
        global::System.DateTime? StartTime { get; set; }

    }
}