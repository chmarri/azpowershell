// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties of a certificate used for authenticating a token.</summary>
    public partial class TokenCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITokenCertificateInternal
    {

        /// <summary>Backing field for <see cref="EncodedPemCertificate" /> property.</summary>
        private string _encodedPemCertificate;

        /// <summary>
        /// Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string EncodedPemCertificate { get => this._encodedPemCertificate; set => this._encodedPemCertificate = value; }

        /// <summary>Backing field for <see cref="Expiry" /> property.</summary>
        private global::System.DateTime? _expiry;

        /// <summary>The expiry datetime of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public global::System.DateTime? Expiry { get => this._expiry; set => this._expiry = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenCertificateName? _name;

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenCertificateName? Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>The thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; set => this._thumbprint = value; }

        /// <summary>Creates an new <see cref="TokenCertificate" /> instance.</summary>
        public TokenCertificate()
        {

        }
    }
    /// The properties of a certificate used for authenticating a token.
    public partial interface ITokenCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token.",
        SerializedName = @"encodedPemCertificate",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedPemCertificate { get; set; }
        /// <summary>The expiry datetime of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The expiry datetime of the certificate.",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Expiry { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenCertificateName) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenCertificateName? Name { get; set; }
        /// <summary>The thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The thumbprint of the certificate.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }

    }
    /// The properties of a certificate used for authenticating a token.
    internal partial interface ITokenCertificateInternal

    {
        /// <summary>
        /// Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token.
        /// </summary>
        string EncodedPemCertificate { get; set; }
        /// <summary>The expiry datetime of the certificate.</summary>
        global::System.DateTime? Expiry { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenCertificateName? Name { get; set; }
        /// <summary>The thumbprint of the certificate.</summary>
        string Thumbprint { get; set; }

    }
}