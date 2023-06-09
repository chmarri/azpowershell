// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    public partial class AssignmentReport :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReport,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal
    {

        /// <summary>Backing field for <see cref="Assignment" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfo _assignment;

        /// <summary>Configuration details of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfo Assignment { get => (this._assignment = this._assignment ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.AssignmentInfo()); set => this._assignment = value; }

        /// <summary>Name of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inlined)]
        public string AssignmentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).Name; }

        /// <summary>Backing field for <see cref="ComplianceStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? _complianceStatus;

        /// <summary>
        /// A value indicating compliance status of the machine for the assigned guest configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? ComplianceStatus { get => this._complianceStatus; }

        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inlined)]
        public string ConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationName; }

        /// <summary>Version of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inlined)]
        public string ConfigurationVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationVersion; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>
        /// End date and time of the guest configuration assignment compliance status check.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ARM resource id of the report for the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Assignment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfo Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.Assignment { get => (this._assignment = this._assignment ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.AssignmentInfo()); set { {_assignment = value;} } }

        /// <summary>Internal Acessors for AssignmentConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IConfigurationInfo Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.AssignmentConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).Configuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).Configuration = value; }

        /// <summary>Internal Acessors for AssignmentName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.AssignmentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).Name = value; }

        /// <summary>Internal Acessors for ComplianceStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.ComplianceStatus { get => this._complianceStatus; set { {_complianceStatus = value;} } }

        /// <summary>Internal Acessors for ConfigurationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.ConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationName = value; }

        /// <summary>Internal Acessors for ConfigurationVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.ConfigurationVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfoInternal)Assignment).ConfigurationVersion = value; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for OperationType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.OperationType { get => this._operationType; set { {_operationType = value;} } }

        /// <summary>Internal Acessors for ReportId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.ReportId { get => this._reportId; set { {_reportId = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for VM</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfo Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.VM { get => (this._vM = this._vM ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.VMInfo()); set { {_vM = value;} } }

        /// <summary>Internal Acessors for VMId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.VMId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Id = value; }

        /// <summary>Internal Acessors for VMUuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportInternal.VMUuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Uuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Uuid = value; }

        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? _operationType;

        /// <summary>Type of report, Consistency or Initial</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get => this._operationType; }

        /// <summary>Backing field for <see cref="ReportId" /> property.</summary>
        private string _reportId;

        /// <summary>
        /// GUID that identifies the guest configuration assignment report under a subscription, resource group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string ReportId { get => this._reportId; }

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

        /// <summary>Backing field for <see cref="VM" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfo _vM;

        /// <summary>Information about the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfo VM { get => (this._vM = this._vM ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.VMInfo()); set => this._vM = value; }

        /// <summary>Azure resource Id of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inlined)]
        public string VMId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Id; }

        /// <summary>UUID(Universally Unique Identifier) of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inlined)]
        public string VMUuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfoInternal)VM).Uuid; }

        /// <summary>Creates an new <see cref="AssignmentReport" /> instance.</summary>
        public AssignmentReport()
        {

        }
    }
    public partial interface IAssignmentReport :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Name of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the guest configuration assignment.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string AssignmentName { get;  }
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
        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the configuration.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationName { get;  }
        /// <summary>Version of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the configuration.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationVersion { get;  }
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
        /// <summary>ARM resource id of the report for the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ARM resource id of the report for the guest configuration assignment.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Type of report, Consistency or Initial</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of report, Consistency or Initial",
        SerializedName = @"operationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get;  }
        /// <summary>
        /// GUID that identifies the guest configuration assignment report under a subscription, resource group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"GUID that identifies the guest configuration assignment report under a subscription, resource group.",
        SerializedName = @"reportId",
        PossibleTypes = new [] { typeof(string) })]
        string ReportId { get;  }
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
        /// <summary>Azure resource Id of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource Id of the VM.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string VMId { get;  }
        /// <summary>UUID(Universally Unique Identifier) of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"UUID(Universally Unique Identifier) of the VM.",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string VMUuid { get;  }

    }
    internal partial interface IAssignmentReportInternal

    {
        /// <summary>Configuration details of the guest configuration assignment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentInfo Assignment { get; set; }
        /// <summary>Information about the configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IConfigurationInfo AssignmentConfiguration { get; set; }
        /// <summary>Name of the guest configuration assignment.</summary>
        string AssignmentName { get; set; }
        /// <summary>
        /// A value indicating compliance status of the machine for the assigned guest configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ComplianceStatus? ComplianceStatus { get; set; }
        /// <summary>Name of the configuration.</summary>
        string ConfigurationName { get; set; }
        /// <summary>Version of the configuration.</summary>
        string ConfigurationVersion { get; set; }
        /// <summary>
        /// End date and time of the guest configuration assignment compliance status check.
        /// </summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>ARM resource id of the report for the guest configuration assignment.</summary>
        string Id { get; set; }
        /// <summary>Type of report, Consistency or Initial</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.Type? OperationType { get; set; }
        /// <summary>
        /// GUID that identifies the guest configuration assignment report under a subscription, resource group.
        /// </summary>
        string ReportId { get; set; }
        /// <summary>
        /// The list of resources for which guest configuration assignment compliance is checked.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IAssignmentReportResource[] Resource { get; set; }
        /// <summary>
        /// Start date and time of the guest configuration assignment compliance status check.
        /// </summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Information about the VM.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVMInfo VM { get; set; }
        /// <summary>Azure resource Id of the VM.</summary>
        string VMId { get; set; }
        /// <summary>UUID(Universally Unique Identifier) of the VM.</summary>
        string VMUuid { get; set; }

    }
}