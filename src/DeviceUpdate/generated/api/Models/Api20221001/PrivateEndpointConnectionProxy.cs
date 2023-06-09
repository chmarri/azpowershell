// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Private endpoint connection proxy details.</summary>
    public partial class PrivateEndpointConnectionProxy :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxy,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGenerated __privateEndpointConnectionProxyPropertiesAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.PrivateEndpointConnectionProxyPropertiesAutoGenerated();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.Resource();

        /// <summary>ETag from NRP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string ETag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).ETag; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.PrivateEndpointConnectionProxyProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PrivateEndpointConnectionProxyProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal.ETag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).ETag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).ETag = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyProperties _property;

        /// <summary>Private endpoint connection proxy object property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.PrivateEndpointConnectionProxyProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PrivateEndpointConnectionProxyProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Remote private endpoint details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IRemotePrivateEndpoint RemotePrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpoint = value ?? null /* model class */; }

        /// <summary>List of connection details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IConnectionDetails[] RemotePrivateEndpointConnectionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointConnectionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointConnectionDetail = value ?? null /* arrayOf */; }

        /// <summary>Remote endpoint resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string RemotePrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointId = value ?? null; }

        /// <summary>Original resource ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string RemotePrivateEndpointImmutableResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointImmutableResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointImmutableResourceId = value ?? null; }

        /// <summary>Original subscription ID needed by Microsoft.Network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string RemotePrivateEndpointImmutableSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointImmutableSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointImmutableSubscriptionId = value ?? null; }

        /// <summary>ARM location of the remote private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string RemotePrivateEndpointLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointLocation = value ?? null; }

        /// <summary>List of private link service connections that need manual approval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointManualPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointManualPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointManualPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>List of automatically approved private link service connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceConnection[] RemotePrivateEndpointPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>List of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateLinkServiceProxy[] RemotePrivateEndpointPrivateLinkServiceProxy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointPrivateLinkServiceProxy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointPrivateLinkServiceProxy = value ?? null /* arrayOf */; }

        /// <summary>Virtual network traffic tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string RemotePrivateEndpointVnetTrafficTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointVnetTrafficTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).RemotePrivateEndpointVnetTrafficTag = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal)__privateEndpointConnectionProxyPropertiesAutoGenerated).Status = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProxy" /> instance.</summary>
        public PrivateEndpointConnectionProxy()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
            await eventListener.AssertNotNull(nameof(__privateEndpointConnectionProxyPropertiesAutoGenerated), __privateEndpointConnectionProxyPropertiesAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__privateEndpointConnectionProxyPropertiesAutoGenerated), __privateEndpointConnectionProxyPropertiesAutoGenerated);
        }
    }
    /// Private endpoint connection proxy details.
    public partial interface IPrivateEndpointConnectionProxy :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGenerated
    {
        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the private endpoint connection proxy resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PrivateEndpointConnectionProxyProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PrivateEndpointConnectionProxyProvisioningState? ProvisioningState { get;  }

    }
    /// Private endpoint connection proxy details.
    internal partial interface IPrivateEndpointConnectionProxyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyPropertiesAutoGeneratedInternal
    {
        /// <summary>Private endpoint connection proxy object property bag.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnectionProxyProperties Property { get; set; }
        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PrivateEndpointConnectionProxyProvisioningState? ProvisioningState { get; set; }

    }
}