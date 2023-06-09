// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Represents Expansion entity query.</summary>
    public partial class ExpansionEntityQuery :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQuery,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueryInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQuery"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQuery __entityQuery = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityQuery();

        /// <summary>List of the data sources that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string[] DataSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).DataSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).DataSource = value ?? null /* arrayOf */; }

        /// <summary>The query display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Etag of the azure resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)__entityQuery).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20.IResourceWithEtagInternal)__entityQuery).Etag = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Id; }

        /// <summary>The type of the query's source entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).InputEntityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).InputEntityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType)""); }

        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string[] InputField { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).InputField; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).InputField = value ?? null /* arrayOf */; }

        /// <summary>the entity query kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityQueryKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryInternal)__entityQuery).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryInternal)__entityQuery).Kind = value ; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueryInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ExpansionEntityQueriesProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Name; }

        /// <summary>List of the desired output types to be constructed from the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType[] OutputEntityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).OutputEntityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).OutputEntityType = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties _property;

        /// <summary>Expansion entity query properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ExpansionEntityQueriesProperties()); set => this._property = value; }

        /// <summary>The template query string to be parsed and formatted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string QueryTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).QueryTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesPropertiesInternal)Property).QueryTemplate = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQuery).Type; }

        /// <summary>Creates an new <see cref="ExpansionEntityQuery" /> instance.</summary>
        public ExpansionEntityQuery()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityQuery), __entityQuery);
            await eventListener.AssertObjectIsValid(nameof(__entityQuery), __entityQuery);
        }
    }
    /// Represents Expansion entity query.
    public partial interface IExpansionEntityQuery :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQuery
    {
        /// <summary>List of the data sources that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the data sources that are required to run the query",
        SerializedName = @"dataSources",
        PossibleTypes = new [] { typeof(string) })]
        string[] DataSource { get; set; }
        /// <summary>The query display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The query display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The type of the query's source entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the query's source entity",
        SerializedName = @"inputEntityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get; set; }
        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the fields of the source entity that are required to run the query",
        SerializedName = @"inputFields",
        PossibleTypes = new [] { typeof(string) })]
        string[] InputField { get; set; }
        /// <summary>List of the desired output types to be constructed from the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the desired output types to be constructed from the result",
        SerializedName = @"outputEntityTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType[] OutputEntityType { get; set; }
        /// <summary>The template query string to be parsed and formatted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The template query string to be parsed and formatted",
        SerializedName = @"queryTemplate",
        PossibleTypes = new [] { typeof(string) })]
        string QueryTemplate { get; set; }

    }
    /// Represents Expansion entity query.
    internal partial interface IExpansionEntityQueryInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryInternal
    {
        /// <summary>List of the data sources that are required to run the query</summary>
        string[] DataSource { get; set; }
        /// <summary>The query display name</summary>
        string DisplayName { get; set; }
        /// <summary>The type of the query's source entity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get; set; }
        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        string[] InputField { get; set; }
        /// <summary>List of the desired output types to be constructed from the result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType[] OutputEntityType { get; set; }
        /// <summary>Expansion entity query properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IExpansionEntityQueriesProperties Property { get; set; }
        /// <summary>The template query string to be parsed and formatted</summary>
        string QueryTemplate { get; set; }

    }
}