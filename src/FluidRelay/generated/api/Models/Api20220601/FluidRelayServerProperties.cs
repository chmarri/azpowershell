// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Extensions;

    /// <summary>The properties of a Fluid Relay Service resource.</summary>
    public partial class FluidRelayServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal
    {

        /// <summary>
        /// key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version.
        /// Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned)
        /// should have permission to access this key url.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public string CustomerManagedKeyEncryptionKeyUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryptionKeyUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryptionKeyUrl = value ?? null; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionProperties _encryption;

        /// <summary>All encryption configuration for a resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionProperties Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.EncryptionProperties()); set => this._encryption = value; }

        /// <summary>Backing field for <see cref="FluidRelayEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpoints _fluidRelayEndpoint;

        /// <summary>The Fluid Relay Service endpoints for this server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpoints FluidRelayEndpoint { get => (this._fluidRelayEndpoint = this._fluidRelayEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.FluidRelayEndpoints()); }

        /// <summary>The Fluid Relay Orderer endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public string[] FluidRelayEndpointOrdererEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).OrdererEndpoint; }

        /// <summary>The Fluid Relay service endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public string[] FluidRelayEndpointServiceEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).ServiceEndpoint; }

        /// <summary>The Fluid Relay storage endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public string[] FluidRelayEndpointStorageEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).StorageEndpoint; }

        /// <summary>Backing field for <see cref="FrsTenantId" /> property.</summary>
        private string _frsTenantId;

        /// <summary>The Fluid tenantId for this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        public string FrsTenantId { get => this._frsTenantId; }

        /// <summary>Values can be SystemAssigned or UserAssigned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CmkIdentityType? KeyEncryptionKeyIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).KeyEncryptionKeyIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).KeyEncryptionKeyIdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CmkIdentityType)""); }

        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).KeyEncryptionKeyIdentityUserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).KeyEncryptionKeyIdentityUserAssignedIdentityResourceId = value ?? null; }

        /// <summary>Internal Acessors for CustomerManagedKeyEncryptionKeyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.ICustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentity Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.CustomerManagedKeyEncryptionKeyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryptionKeyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryptionKeyIdentity = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionProperties Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.EncryptionProperties()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionCustomerManagedKeyEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.ICustomerManagedKeyEncryptionProperties Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.EncryptionCustomerManagedKeyEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionPropertiesInternal)Encryption).CustomerManagedKeyEncryption = value; }

        /// <summary>Internal Acessors for FluidRelayEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpoints Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.FluidRelayEndpoint { get => (this._fluidRelayEndpoint = this._fluidRelayEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.FluidRelayEndpoints()); set { {_fluidRelayEndpoint = value;} } }

        /// <summary>Internal Acessors for FluidRelayEndpointOrdererEndpoint</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.FluidRelayEndpointOrdererEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).OrdererEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).OrdererEndpoint = value; }

        /// <summary>Internal Acessors for FluidRelayEndpointServiceEndpoint</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.FluidRelayEndpointServiceEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).ServiceEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).ServiceEndpoint = value; }

        /// <summary>Internal Acessors for FluidRelayEndpointStorageEndpoint</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.FluidRelayEndpointStorageEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).StorageEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpointsInternal)FluidRelayEndpoint).StorageEndpoint = value; }

        /// <summary>Internal Acessors for FrsTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerPropertiesInternal.FrsTenantId { get => this._frsTenantId; set { {_frsTenantId = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? _provisioningState;

        /// <summary>Provision states for FluidRelay RP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="Storagesku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.StorageSku? _storagesku;

        /// <summary>Sku of the storage associated with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Origin(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.StorageSku? Storagesku { get => this._storagesku; set => this._storagesku = value; }

        /// <summary>Creates an new <see cref="FluidRelayServerProperties" /> instance.</summary>
        public FluidRelayServerProperties()
        {

        }
    }
    /// The properties of a Fluid Relay Service resource.
    public partial interface IFluidRelayServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.IJsonSerializable
    {
        /// <summary>
        /// key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version.
        /// Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned)
        /// should have permission to access this key url.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78 or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version. Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned) should have permission to access this key url.",
        SerializedName = @"keyEncryptionKeyUrl",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerManagedKeyEncryptionKeyUrl { get; set; }
        /// <summary>The Fluid Relay Orderer endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Fluid Relay Orderer endpoints.",
        SerializedName = @"ordererEndpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] FluidRelayEndpointOrdererEndpoint { get;  }
        /// <summary>The Fluid Relay service endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Fluid Relay service endpoints.",
        SerializedName = @"serviceEndpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] FluidRelayEndpointServiceEndpoint { get;  }
        /// <summary>The Fluid Relay storage endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Fluid Relay storage endpoints.",
        SerializedName = @"storageEndpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] FluidRelayEndpointStorageEndpoint { get;  }
        /// <summary>The Fluid tenantId for this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Fluid tenantId for this server",
        SerializedName = @"frsTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string FrsTenantId { get;  }
        /// <summary>Values can be SystemAssigned or UserAssigned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Values can be SystemAssigned or UserAssigned",
        SerializedName = @"identityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CmkIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CmkIdentityType? KeyEncryptionKeyIdentityType { get; set; }
        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity.",
        SerializedName = @"userAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>Provision states for FluidRelay RP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provision states for FluidRelay RP",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Sku of the storage associated with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sku of the storage associated with the resource",
        SerializedName = @"storagesku",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.StorageSku) })]
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.StorageSku? Storagesku { get; set; }

    }
    /// The properties of a Fluid Relay Service resource.
    internal partial interface IFluidRelayServerPropertiesInternal

    {
        /// <summary>
        /// All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.ICustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentity CustomerManagedKeyEncryptionKeyIdentity { get; set; }
        /// <summary>
        /// key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version.
        /// Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned)
        /// should have permission to access this key url.
        /// </summary>
        string CustomerManagedKeyEncryptionKeyUrl { get; set; }
        /// <summary>All encryption configuration for a resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IEncryptionProperties Encryption { get; set; }
        /// <summary>All Customer-managed key encryption properties for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.ICustomerManagedKeyEncryptionProperties EncryptionCustomerManagedKeyEncryption { get; set; }
        /// <summary>The Fluid Relay Service endpoints for this server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayEndpoints FluidRelayEndpoint { get; set; }
        /// <summary>The Fluid Relay Orderer endpoints.</summary>
        string[] FluidRelayEndpointOrdererEndpoint { get; set; }
        /// <summary>The Fluid Relay service endpoints.</summary>
        string[] FluidRelayEndpointServiceEndpoint { get; set; }
        /// <summary>The Fluid Relay storage endpoints.</summary>
        string[] FluidRelayEndpointStorageEndpoint { get; set; }
        /// <summary>The Fluid tenantId for this server</summary>
        string FrsTenantId { get; set; }
        /// <summary>Values can be SystemAssigned or UserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.CmkIdentityType? KeyEncryptionKeyIdentityType { get; set; }
        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity.
        /// </summary>
        string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>Provision states for FluidRelay RP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Sku of the storage associated with the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Support.StorageSku? Storagesku { get; set; }

    }
}