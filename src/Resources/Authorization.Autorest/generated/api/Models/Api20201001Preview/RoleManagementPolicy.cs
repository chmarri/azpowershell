// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Extensions;

    /// <summary>Role management policy</summary>
    public partial class RoleManagementPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal
    {

        /// <summary>The role management policy description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>The role management policy display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>The readonly computed rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).EffectiveRule; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The role management policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.FormatTable(Index = 1)]
        public string Id { get => this._id; }

        /// <summary>The role management policy is default policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public bool? IsOrganizationDefault { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).IsOrganizationDefault; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).IsOrganizationDefault = value ?? default(bool); }

        /// <summary>The name of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string LastModifiedByDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByDisplayName = value ?? null; }

        /// <summary>Email of principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string LastModifiedByEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByEmail = value ?? null; }

        /// <summary>The id of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string LastModifiedById { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedById; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedById = value ?? null; }

        /// <summary>Type of principal such as user , group etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string LastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedByType = value ?? null; }

        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public global::System.DateTime? LastModifiedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedDateTime; }

        /// <summary>Internal Acessors for EffectiveRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.EffectiveRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).EffectiveRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).EffectiveRule = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LastModifiedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.LastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedBy = value; }

        /// <summary>Internal Acessors for LastModifiedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.LastModifiedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).LastModifiedDateTime = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PolicyProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyProperties Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.PolicyProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).PolicyProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).PolicyProperty = value; }

        /// <summary>Internal Acessors for PolicyPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.PolicyPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).PolicyPropertyScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).PolicyPropertyScope = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Scope = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The role management policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties _property;

        /// <summary>Role management policy properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Rule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Rule = value ?? null /* arrayOf */; }

        /// <summary>The role management policy scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.FormatTable(Index = 3)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).Scope; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.DoNotFormat]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)Property).ScopeType = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The role management policy type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.FormatTable(Index = 2)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="RoleManagementPolicy" /> instance.</summary>
        public RoleManagementPolicy()
        {

        }
    }
    /// Role management policy
    public partial interface IRoleManagementPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The role management policy description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The role management policy display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The readonly computed rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The readonly computed rule applied to the policy.",
        SerializedName = @"effectiveRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get;  }
        /// <summary>The role management policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role management policy Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The role management policy is default policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy is default policy.",
        SerializedName = @"isOrganizationDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOrganizationDefault { get; set; }
        /// <summary>The name of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the principal made changes",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByDisplayName { get; set; }
        /// <summary>Email of principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of principal",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByEmail { get; set; }
        /// <summary>The id of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the principal made changes",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedById { get; set; }
        /// <summary>Type of principal such as user , group etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of principal such as user , group etc",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByType { get; set; }
        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last modified date time.",
        SerializedName = @"lastModifiedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedDateTime { get;  }
        /// <summary>The role management policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role management policy name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The rule applied to the policy.",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get; set; }
        /// <summary>The role management policy scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role management policy scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get;  }
        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the resource",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scope id of the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeType { get; set; }
        /// <summary>The role management policy type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role management policy type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Role management policy
    internal partial interface IRoleManagementPolicyInternal

    {
        /// <summary>The role management policy description.</summary>
        string Description { get; set; }
        /// <summary>The role management policy display name.</summary>
        string DisplayName { get; set; }
        /// <summary>The readonly computed rule applied to the policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get; set; }
        /// <summary>The role management policy Id.</summary>
        string Id { get; set; }
        /// <summary>The role management policy is default policy.</summary>
        bool? IsOrganizationDefault { get; set; }
        /// <summary>The name of the entity last modified it</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal LastModifiedBy { get; set; }
        /// <summary>The name of the principal made changes</summary>
        string LastModifiedByDisplayName { get; set; }
        /// <summary>Email of principal</summary>
        string LastModifiedByEmail { get; set; }
        /// <summary>The id of the principal made changes</summary>
        string LastModifiedById { get; set; }
        /// <summary>Type of principal such as user , group etc</summary>
        string LastModifiedByType { get; set; }
        /// <summary>The last modified date time.</summary>
        global::System.DateTime? LastModifiedDateTime { get; set; }
        /// <summary>The role management policy name.</summary>
        string Name { get; set; }
        /// <summary>Additional properties of scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyProperties PolicyProperty { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope PolicyPropertyScope { get; set; }
        /// <summary>Role management policy properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties Property { get; set; }
        /// <summary>The rule applied to the policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get; set; }
        /// <summary>The role management policy scope.</summary>
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }
        /// <summary>The role management policy type.</summary>
        string Type { get; set; }

    }
}