// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The TLS certificate properties of the connected registry login server.</summary>
    public partial class TlsCertificateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITlsCertificateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITlsCertificatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Indicates the location of the certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITlsCertificatePropertiesInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ITlsCertificatePropertiesInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? _type;

        /// <summary>The type of certificate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? Type { get => this._type; }

        /// <summary>Creates an new <see cref="TlsCertificateProperties" /> instance.</summary>
        public TlsCertificateProperties()
        {

        }
    }
    /// The TLS certificate properties of the connected registry login server.
    public partial interface ITlsCertificateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the location of the certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the location of the certificates.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>The type of certificate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of certificate location.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? Type { get;  }

    }
    /// The TLS certificate properties of the connected registry login server.
    internal partial interface ITlsCertificatePropertiesInternal

    {
        /// <summary>Indicates the location of the certificates.</summary>
        string Location { get; set; }
        /// <summary>The type of certificate location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? Type { get; set; }

    }
}