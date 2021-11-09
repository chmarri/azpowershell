// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents a Configuration.</summary>
    public partial class ConfigurationAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.Resource();

        /// <summary>Allowed values of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.FormatTable(Index = 2)]
        public string AllowedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).AllowedValue; }

        /// <summary>Data type of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string DataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DataType; }

        /// <summary>Default value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.FormatTable(Index = 4)]
        public string DefaultValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DefaultValue; }

        /// <summary>Description of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Description; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>If is the configuration pending restart or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart? IsConfigPendingRestart { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsConfigPendingRestart; }

        /// <summary>If is the configuration dynamic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig? IsDynamicConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsDynamicConfig; }

        /// <summary>If is the configuration read only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly? IsReadOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsReadOnly; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for AllowedValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.AllowedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).AllowedValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).AllowedValue = value; }

        /// <summary>Internal Acessors for DataType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.DataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DataType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DataType = value; }

        /// <summary>Internal Acessors for DefaultValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.DefaultValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DefaultValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).DefaultValue = value; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Description = value; }

        /// <summary>Internal Acessors for IsConfigPendingRestart</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.IsConfigPendingRestart { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsConfigPendingRestart; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsConfigPendingRestart = value; }

        /// <summary>Internal Acessors for IsDynamicConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.IsDynamicConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsDynamicConfig; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsDynamicConfig = value; }

        /// <summary>Internal Acessors for IsReadOnly</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.IsReadOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsReadOnly; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).IsReadOnly = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGeneratedInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated _property;

        /// <summary>The properties of a configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated()); set => this._property = value; }

        /// <summary>Source of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.FormatTable(Index = 3)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource? Source { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Source = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource)""); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemData _systemData;

        /// <summary>The system metadata relating to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.FormatTable(Index = 1)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)Property).Value = value ?? null; }

        /// <summary>Creates an new <see cref="ConfigurationAutoGenerated" /> instance.</summary>
        public ConfigurationAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Represents a Configuration.
    public partial interface IConfigurationAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResource
    {
        /// <summary>Allowed values of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Allowed values of the configuration.",
        SerializedName = @"allowedValues",
        PossibleTypes = new [] { typeof(string) })]
        string AllowedValue { get;  }
        /// <summary>Data type of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Data type of the configuration.",
        SerializedName = @"dataType",
        PossibleTypes = new [] { typeof(string) })]
        string DataType { get;  }
        /// <summary>Default value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Default value of the configuration.",
        SerializedName = @"defaultValue",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultValue { get;  }
        /// <summary>Description of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the configuration.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>If is the configuration pending restart or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"If is the configuration pending restart or not.",
        SerializedName = @"isConfigPendingRestart",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart? IsConfigPendingRestart { get;  }
        /// <summary>If is the configuration dynamic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"If is the configuration dynamic.",
        SerializedName = @"isDynamicConfig",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig? IsDynamicConfig { get;  }
        /// <summary>If is the configuration read only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"If is the configuration read only.",
        SerializedName = @"isReadOnly",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly? IsReadOnly { get;  }
        /// <summary>Source of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source of the configuration.",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource? Source { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value of the configuration.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Represents a Configuration.
    internal partial interface IConfigurationAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api10.IResourceInternal
    {
        /// <summary>Allowed values of the configuration.</summary>
        string AllowedValue { get; set; }
        /// <summary>Data type of the configuration.</summary>
        string DataType { get; set; }
        /// <summary>Default value of the configuration.</summary>
        string DefaultValue { get; set; }
        /// <summary>Description of the configuration.</summary>
        string Description { get; set; }
        /// <summary>If is the configuration pending restart or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart? IsConfigPendingRestart { get; set; }
        /// <summary>If is the configuration dynamic.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig? IsDynamicConfig { get; set; }
        /// <summary>If is the configuration read only.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly? IsReadOnly { get; set; }
        /// <summary>The properties of a configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated Property { get; set; }
        /// <summary>Source of the configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource? Source { get; set; }
        /// <summary>The system metadata relating to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Value of the configuration.</summary>
        string Value { get; set; }

    }
}