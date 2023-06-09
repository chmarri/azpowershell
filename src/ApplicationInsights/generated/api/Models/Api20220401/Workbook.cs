// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>A workbook definition.</summary>
    public partial class Workbook :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbook,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResource __workbookResource = new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.WorkbookResource();

        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 5)]
        public string Category { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Category; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Category = value ?? null; }

        /// <summary>The description of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>The user-defined name (display name) of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 2)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Resource etag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Etag = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Id; }

        /// <summary>Identity used for BYOS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api30.IManagedServiceIdentity Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Identity = value ?? null /* model class */; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityPrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityTenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ManagedServiceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityUserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The kind of workbook. Only valid value is shared.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 4)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookSharedTypeKind? Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).Kind = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookSharedTypeKind)""); }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 3)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ITrackedResourceInternal)__workbookResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ITrackedResourceInternal)__workbookResource).Location = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookProperties Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.WorkbookProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Revision</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal.Revision { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Revision; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Revision = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for TimeModified</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal.TimeModified { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).TimeModified; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).TimeModified = value; }

        /// <summary>Internal Acessors for UserId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookInternal.UserId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).UserId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).UserId = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal)__workbookResource).IdentityTenantId = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 1)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Name; }

        /// <summary>Being deprecated, please use the other tags field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string[] PropertiesTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Tag = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookProperties _property;

        /// <summary>Metadata describing a workbook for an Azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.WorkbookProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 0)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The unique revision id for this workbook definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Revision { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Revision; }

        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SerializedData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).SerializedData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).SerializedData = value ?? null; }

        /// <summary>ResourceId for a source resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).SourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).SourceId = value ?? null; }

        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string StorageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).StorageUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).StorageUri = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ITrackedResourceInternal)__workbookResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ITrackedResourceInternal)__workbookResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public global::System.DateTime? TimeModified { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).TimeModified; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.IResourceInternal)__workbookResource).Type; }

        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string UserId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).UserId; }

        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workbookResource), __workbookResource);
            await eventListener.AssertObjectIsValid(nameof(__workbookResource), __workbookResource);
        }

        /// <summary>Creates an new <see cref="Workbook" /> instance.</summary>
        public Workbook()
        {

        }
    }
    /// A workbook definition.
    public partial interface IWorkbook :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResource
    {
        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Workbook category, as defined by the user at creation time.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The description of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the workbook.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The user-defined name (display name) of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user-defined name (display name) of the workbook.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Being deprecated, please use the other tags field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Being deprecated, please use the other tags field",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertiesTag { get; set; }
        /// <summary>The unique revision id for this workbook definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique revision id for this workbook definition",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(string) })]
        string Revision { get;  }
        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration of this particular workbook. Configuration data is a string containing valid JSON",
        SerializedName = @"serializedData",
        PossibleTypes = new [] { typeof(string) })]
        string SerializedData { get; set; }
        /// <summary>ResourceId for a source resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceId for a source resource.",
        SerializedName = @"sourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceId { get; set; }
        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resourceId to the storage account when bring your own storage is used",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string StorageUri { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Date and time in UTC of the last modification that was made to this workbook definition.",
        SerializedName = @"timeModified",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeModified { get;  }
        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Unique user id of the specific user that owns this workbook.",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get;  }
        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// A workbook definition.
    internal partial interface IWorkbookInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookResourceInternal
    {
        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        string Category { get; set; }
        /// <summary>The description of the workbook.</summary>
        string Description { get; set; }
        /// <summary>The user-defined name (display name) of the workbook.</summary>
        string DisplayName { get; set; }
        /// <summary>Being deprecated, please use the other tags field</summary>
        string[] PropertiesTag { get; set; }
        /// <summary>Metadata describing a workbook for an Azure resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookProperties Property { get; set; }
        /// <summary>The unique revision id for this workbook definition</summary>
        string Revision { get; set; }
        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        string SerializedData { get; set; }
        /// <summary>ResourceId for a source resource.</summary>
        string SourceId { get; set; }
        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        string StorageUri { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        global::System.DateTime? TimeModified { get; set; }
        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        string UserId { get; set; }
        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        string Version { get; set; }

    }
}