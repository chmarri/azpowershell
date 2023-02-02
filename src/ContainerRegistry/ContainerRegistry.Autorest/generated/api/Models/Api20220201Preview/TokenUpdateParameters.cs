// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The parameters for updating a token.</summary>
    public partial class TokenUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateParametersInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificate[] CredentialsCertificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).CredentialsCertificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).CredentialsCertificate = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenPassword[] CredentialsPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).CredentialsPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).CredentialsPassword = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateParametersInternal.Credentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).Credentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).Credentials = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.TokenUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateProperties _property;

        /// <summary>The properties of the token update parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.TokenUpdateProperties()); set => this._property = value; }

        /// <summary>The resource ID of the scope map to which the token will be associated with.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string ScopeMapId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).ScopeMapId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).ScopeMapId = value ?? null; }

        /// <summary>The status of the token example enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdatePropertiesInternal)Property).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenStatus)""); }

        /// <summary>Creates an new <see cref="TokenUpdateParameters" /> instance.</summary>
        public TokenUpdateParameters()
        {

        }
    }
    /// The parameters for updating a token.
    public partial interface ITokenUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"certificates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificate) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificate[] CredentialsCertificate { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenPassword) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenPassword[] CredentialsPassword { get; set; }
        /// <summary>The resource ID of the scope map to which the token will be associated with.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the scope map to which the token will be associated with.",
        SerializedName = @"scopeMapId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeMapId { get; set; }
        /// <summary>The status of the token example enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the token example enabled or disabled.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenStatus? Status { get; set; }

    }
    /// The parameters for updating a token.
    internal partial interface ITokenUpdateParametersInternal

    {
        /// <summary>The credentials that can be used for authenticating the token.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCredentialsProperties Credentials { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificate[] CredentialsCertificate { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenPassword[] CredentialsPassword { get; set; }
        /// <summary>The properties of the token update parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenUpdateProperties Property { get; set; }
        /// <summary>The resource ID of the scope map to which the token will be associated with.</summary>
        string ScopeMapId { get; set; }
        /// <summary>The status of the token example enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenStatus? Status { get; set; }

    }
}