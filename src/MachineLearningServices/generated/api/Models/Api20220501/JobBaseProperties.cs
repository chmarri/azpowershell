// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Base definition for a job.</summary>
    public partial class JobBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBase __resourceBase = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBase();

        /// <summary>Backing field for <see cref="ComputeId" /> property.</summary>
        private string _computeId;

        /// <summary>ARM resource ID of the compute resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ComputeId { get => this._computeId; set => this._computeId = value; }

        /// <summary>The asset description text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Description = value ?? null; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="ExperimentName" /> property.</summary>
        private string _experimentName;

        /// <summary>
        /// The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ExperimentName { get => this._experimentName; set => this._experimentName = value; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration _identity;

        /// <summary>
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IdentityConfiguration()); set => this._identity = value; }

        /// <summary>[Required] Specifies the type of identity framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfigurationInternal)Identity).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfigurationInternal)Identity).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType)""); }

        /// <summary>Backing field for <see cref="IsArchived" /> property.</summary>
        private bool? _isArchived;

        /// <summary>Is the asset archived?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public bool? IsArchived { get => this._isArchived; set => this._isArchived = value; }

        /// <summary>Backing field for <see cref="JobType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType _jobType;

        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType JobType { get => this._jobType; set => this._jobType = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IdentityConfiguration()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>The asset property dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties Property { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Property = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices _service;

        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices Service { get => (this._service = this._service ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseServices()); set => this._service = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? _status;

        /// <summary>Status of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Status { get => this._status; }

        /// <summary>Tag dictionary. Tags can be added, removed, and updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__resourceBase).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="JobBaseProperties" /> instance.</summary>
        public JobBaseProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceBase), __resourceBase);
            await eventListener.AssertObjectIsValid(nameof(__resourceBase), __resourceBase);
        }
    }
    /// Base definition for a job.
    public partial interface IJobBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBase
    {
        /// <summary>ARM resource ID of the compute resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource ID of the compute resource.",
        SerializedName = @"computeId",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeId { get; set; }
        /// <summary>Display name of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of job.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the experiment the job belongs to. If not set, the job is placed in the ""Default"" experiment.",
        SerializedName = @"experimentName",
        PossibleTypes = new [] { typeof(string) })]
        string ExperimentName { get; set; }
        /// <summary>[Required] Specifies the type of identity framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] Specifies the type of identity framework.",
        SerializedName = @"identityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType? IdentityType { get; set; }
        /// <summary>Is the asset archived?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the asset archived?",
        SerializedName = @"isArchived",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsArchived { get; set; }
        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] Specifies the type of job.",
        SerializedName = @"jobType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType JobType { get; set; }
        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of JobEndpoints.
        For local jobs, a job endpoint will have an endpoint value of FileStreamObject.",
        SerializedName = @"services",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices Service { get; set; }
        /// <summary>Status of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the job.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Status { get;  }

    }
    /// Base definition for a job.
    internal partial interface IJobBasePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal
    {
        /// <summary>ARM resource ID of the compute resource.</summary>
        string ComputeId { get; set; }
        /// <summary>Display name of job.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment.
        /// </summary>
        string ExperimentName { get; set; }
        /// <summary>
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration Identity { get; set; }
        /// <summary>[Required] Specifies the type of identity framework.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType? IdentityType { get; set; }
        /// <summary>Is the asset archived?</summary>
        bool? IsArchived { get; set; }
        /// <summary>[Required] Specifies the type of job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType JobType { get; set; }
        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices Service { get; set; }
        /// <summary>Status of the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Status { get; set; }

    }
}