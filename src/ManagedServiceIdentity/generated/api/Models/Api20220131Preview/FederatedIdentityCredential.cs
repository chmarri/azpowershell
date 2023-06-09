// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Extensions;

    /// <summary>Describes a federated identity credential.</summary>
    public partial class FederatedIdentityCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredential,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.Resource();

        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 3)]
        public string[] Audience { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Audience = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 1)]
        public string Issuer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Issuer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Issuer = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.FederatedIdentityCredentialProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties _property;

        /// <summary>The properties associated with the federated identity credential.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.FederatedIdentityCredentialProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 2)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Subject = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="FederatedIdentityCredential" /> instance.</summary>
        public FederatedIdentityCredential()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Describes a federated identity credential.
    public partial interface IFederatedIdentityCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResource
    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of audiences that can appear in the issued token.",
        SerializedName = @"audiences",
        PossibleTypes = new [] { typeof(string) })]
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the issuer to be trusted.",
        SerializedName = @"issuer",
        PossibleTypes = new [] { typeof(string) })]
        string Issuer { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the external identity.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }

    }
    /// Describes a federated identity credential.
    internal partial interface IFederatedIdentityCredentialInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api10.IResourceInternal
    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        string Issuer { get; set; }
        /// <summary>The properties associated with the federated identity credential.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Property { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        string Subject { get; set; }

    }
}