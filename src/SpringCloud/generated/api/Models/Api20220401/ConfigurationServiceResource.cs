// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Application Configuration Service resource</summary>
    public partial class ConfigurationServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResource,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.Resource();

        /// <summary>Repositories of Application Configuration Service git property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitRepository[] GitPropertyRepository { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).GitPropertyRepository; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).GitPropertyRepository = value ?? null /* arrayOf */; }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Id; }

        /// <summary>Collection of instances belong to Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceInstance[] Instance { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).Instance; }

        /// <summary>Internal Acessors for Instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceInstance[] Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.Instance { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).Instance; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).Instance = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceProperties Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ConfigurationServiceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ConfigurationServiceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceRequests Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.ResourceRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequest = value; }

        /// <summary>Internal Acessors for ResourceRequestCpu</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.ResourceRequestCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestCpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestCpu = value; }

        /// <summary>Internal Acessors for ResourceRequestInstanceCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.ResourceRequestInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestInstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestInstanceCount = value; }

        /// <summary>Internal Acessors for ResourceRequestMemory</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.ResourceRequestMemory { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestMemory; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestMemory = value; }

        /// <summary>Internal Acessors for Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceSettings Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.Setting { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).Setting; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).Setting = value; }

        /// <summary>Internal Acessors for SettingGitProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitProperty Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceInternal.SettingGitProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).SettingGitProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).SettingGitProperty = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceProperties _property;

        /// <summary>Application Configuration Service properties payload</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ConfigurationServiceProperties()); set => this._property = value; }

        /// <summary>State of the Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ConfigurationServiceProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Cpu allocated to each Application Configuration Service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string ResourceRequestCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestCpu; }

        /// <summary>Instance count of the Application Configuration Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public int? ResourceRequestInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestInstanceCount; }

        /// <summary>Memory allocated to each Application Configuration Service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inlined)]
        public string ResourceRequestMemory { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServicePropertiesInternal)Property).ResourceRequestMemory; }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource modification (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.LastModifiedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.LastModifiedByType)""); }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ConfigurationServiceResource" /> instance.</summary>
        public ConfigurationServiceResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Application Configuration Service resource
    public partial interface IConfigurationServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResource
    {
        /// <summary>Repositories of Application Configuration Service git property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Repositories of Application Configuration Service git property.",
        SerializedName = @"repositories",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitRepository) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitRepository[] GitPropertyRepository { get; set; }
        /// <summary>Collection of instances belong to Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Collection of instances belong to Application Configuration Service.",
        SerializedName = @"instances",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceInstance[] Instance { get;  }
        /// <summary>State of the Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the Application Configuration Service.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ConfigurationServiceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ConfigurationServiceProvisioningState? ProvisioningState { get;  }
        /// <summary>Cpu allocated to each Application Configuration Service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Cpu allocated to each Application Configuration Service instance",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceRequestCpu { get;  }
        /// <summary>Instance count of the Application Configuration Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Instance count of the Application Configuration Service",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ResourceRequestInstanceCount { get;  }
        /// <summary>Memory allocated to each Application Configuration Service instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Memory allocated to each Application Configuration Service instance",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceRequestMemory { get;  }

    }
    /// Application Configuration Service resource
    internal partial interface IConfigurationServiceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IResourceInternal
    {
        /// <summary>Repositories of Application Configuration Service git property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitRepository[] GitPropertyRepository { get; set; }
        /// <summary>Collection of instances belong to Application Configuration Service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceInstance[] Instance { get; set; }
        /// <summary>Application Configuration Service properties payload</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceProperties Property { get; set; }
        /// <summary>State of the Application Configuration Service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ConfigurationServiceProvisioningState? ProvisioningState { get; set; }
        /// <summary>The requested resource quantity for required CPU and Memory.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceResourceRequests ResourceRequest { get; set; }
        /// <summary>Cpu allocated to each Application Configuration Service instance</summary>
        string ResourceRequestCpu { get; set; }
        /// <summary>Instance count of the Application Configuration Service</summary>
        int? ResourceRequestInstanceCount { get; set; }
        /// <summary>Memory allocated to each Application Configuration Service instance</summary>
        string ResourceRequestMemory { get; set; }
        /// <summary>The settings of Application Configuration Service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceSettings Setting { get; set; }
        /// <summary>Property of git environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitProperty SettingGitProperty { get; set; }

    }
}