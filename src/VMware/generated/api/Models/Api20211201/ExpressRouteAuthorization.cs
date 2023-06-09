// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>ExpressRoute Circuit Authorization</summary>
    public partial class ExpressRouteAuthorization :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorization,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.Resource();

        /// <summary>The ID of the ExpressRoute Circuit Authorization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string ExpressRouteAuthorizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationId; }

        /// <summary>The ID of the ExpressRoute Circuit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string ExpressRouteId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteId = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id; }

        /// <summary>The key of the ExpressRoute Circuit Authorization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string Key { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationKey; }

        /// <summary>Internal Acessors for ExpressRouteAuthorizationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationInternal.ExpressRouteAuthorizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationId = value; }

        /// <summary>Internal Acessors for Key</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationInternal.Key { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ExpressRouteAuthorizationKey = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.ExpressRouteAuthorizationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationProperties _property;

        /// <summary>The properties of an ExpressRoute Circuit Authorization resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.ExpressRouteAuthorizationProperties()); }

        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ExpressRouteAuthorization" /> instance.</summary>
        public ExpressRouteAuthorization()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// ExpressRoute Circuit Authorization
    public partial interface IExpressRouteAuthorization :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource
    {
        /// <summary>The ID of the ExpressRoute Circuit Authorization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ID of the ExpressRoute Circuit Authorization",
        SerializedName = @"expressRouteAuthorizationId",
        PossibleTypes = new [] { typeof(string) })]
        string ExpressRouteAuthorizationId { get;  }
        /// <summary>The ID of the ExpressRoute Circuit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the ExpressRoute Circuit",
        SerializedName = @"expressRouteId",
        PossibleTypes = new [] { typeof(string) })]
        string ExpressRouteId { get; set; }
        /// <summary>The key of the ExpressRoute Circuit Authorization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The key of the ExpressRoute Circuit Authorization",
        SerializedName = @"expressRouteAuthorizationKey",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get;  }
        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the  ExpressRoute Circuit Authorization provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState? ProvisioningState { get;  }

    }
    /// ExpressRoute Circuit Authorization
    internal partial interface IExpressRouteAuthorizationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal
    {
        /// <summary>The ID of the ExpressRoute Circuit Authorization</summary>
        string ExpressRouteAuthorizationId { get; set; }
        /// <summary>The ID of the ExpressRoute Circuit</summary>
        string ExpressRouteId { get; set; }
        /// <summary>The key of the ExpressRoute Circuit Authorization</summary>
        string Key { get; set; }
        /// <summary>The properties of an ExpressRoute Circuit Authorization resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IExpressRouteAuthorizationProperties Property { get; set; }
        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState? ProvisioningState { get; set; }

    }
}