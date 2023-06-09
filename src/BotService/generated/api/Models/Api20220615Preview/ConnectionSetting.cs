// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>Bot channel resource definition</summary>
    public partial class ConnectionSetting :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSetting,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.Resource();

        /// <summary>Client Id associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ClientId = value ?? null; }

        /// <summary>Client Secret associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ClientSecret { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ClientSecret; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ClientSecret = value ?? null; }

        /// <summary>Entity Tag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Etag = value ?? null; }

        /// <summary>Specifies the resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Id; }

        /// <summary>Required. Gets or sets the Kind of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.Kind? Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Kind = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.Kind)""); }

        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SettingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingInternal.SettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).SettingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).SettingId = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SkuTier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.SkuTier? Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal.SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).SkuTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).SkuTier = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Zone</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal.Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Zone = value; }

        /// <summary>Specifies the name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Name; }

        /// <summary>Service Provider Parameters associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter[] Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Parameter = value ?? null /* arrayOf */; }

        /// <summary>Id associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string PropertiesId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Id = value ?? null; }

        /// <summary>Name associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string PropertiesName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties _property;

        /// <summary>The set of properties specific to bot channel resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ConnectionSettingProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Scopes associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).Scope = value ?? null; }

        /// <summary>Service Provider Display Name associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ServiceProviderDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ServiceProviderDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ServiceProviderDisplayName = value ?? null; }

        /// <summary>Service Provider Id associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ServiceProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ServiceProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).ServiceProviderId = value ?? null; }

        /// <summary>Setting Id set by the service for the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string SettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingPropertiesInternal)Property).SettingId; }

        /// <summary>Gets or sets the SKU of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.ISku Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Sku = value ?? null /* model class */; }

        /// <summary>The sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.SkuName? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).SkuName = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.SkuName)""); }

        /// <summary>Gets the sku tier. This is based on the SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.SkuTier? SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).SkuTier; }

        /// <summary>Contains resource tags defined as key/value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Specifies the type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Type; }

        /// <summary>Entity zones</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string[] Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal)__resource).Zone; }

        /// <summary>Creates an new <see cref="ConnectionSetting" /> instance.</summary>
        public ConnectionSetting()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Bot channel resource definition
    public partial interface IConnectionSetting :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResource
    {
        /// <summary>Client Id associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Client Id associated with the Connection Setting.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }
        /// <summary>Client Secret associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Client Secret associated with the Connection Setting",
        SerializedName = @"clientSecret",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecret { get; set; }
        /// <summary>Service Provider Parameters associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service Provider Parameters associated with the Connection Setting",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter[] Parameter { get; set; }
        /// <summary>Id associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id associated with the Connection Setting.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesId { get; set; }
        /// <summary>Name associated with the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name associated with the Connection Setting.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesName { get; set; }
        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }
        /// <summary>Scopes associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scopes associated with the Connection Setting",
        SerializedName = @"scopes",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>Service Provider Display Name associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service Provider Display Name associated with the Connection Setting",
        SerializedName = @"serviceProviderDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceProviderDisplayName { get; set; }
        /// <summary>Service Provider Id associated with the Connection Setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service Provider Id associated with the Connection Setting",
        SerializedName = @"serviceProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceProviderId { get; set; }
        /// <summary>Setting Id set by the service for the Connection Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Setting Id set by the service for the Connection Setting.",
        SerializedName = @"settingId",
        PossibleTypes = new [] { typeof(string) })]
        string SettingId { get;  }

    }
    /// Bot channel resource definition
    internal partial interface IConnectionSettingInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IResourceInternal
    {
        /// <summary>Client Id associated with the Connection Setting.</summary>
        string ClientId { get; set; }
        /// <summary>Client Secret associated with the Connection Setting</summary>
        string ClientSecret { get; set; }
        /// <summary>Service Provider Parameters associated with the Connection Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingParameter[] Parameter { get; set; }
        /// <summary>Id associated with the Connection Setting.</summary>
        string PropertiesId { get; set; }
        /// <summary>Name associated with the Connection Setting.</summary>
        string PropertiesName { get; set; }
        /// <summary>The set of properties specific to bot channel resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IConnectionSettingProperties Property { get; set; }
        /// <summary>Provisioning state of the resource</summary>
        string ProvisioningState { get; set; }
        /// <summary>Scopes associated with the Connection Setting</summary>
        string Scope { get; set; }
        /// <summary>Service Provider Display Name associated with the Connection Setting</summary>
        string ServiceProviderDisplayName { get; set; }
        /// <summary>Service Provider Id associated with the Connection Setting</summary>
        string ServiceProviderId { get; set; }
        /// <summary>Setting Id set by the service for the Connection Setting.</summary>
        string SettingId { get; set; }

    }
}