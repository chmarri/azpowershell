// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>Properties that describe a base image dependency.</summary>
    public partial class BaseImageDependency :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageDependency,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageDependencyInternal
    {

        /// <summary>Backing field for <see cref="Digest" /> property.</summary>
        private string _digest;

        /// <summary>The sha256-based digest of the image manifest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Digest { get => this._digest; set => this._digest = value; }

        /// <summary>Backing field for <see cref="Registry" /> property.</summary>
        private string _registry;

        /// <summary>The registry login server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Registry { get => this._registry; set => this._registry = value; }

        /// <summary>Backing field for <see cref="Repository" /> property.</summary>
        private string _repository;

        /// <summary>The repository name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Repository { get => this._repository; set => this._repository = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string _tag;

        /// <summary>The tag name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageDependencyType? _type;

        /// <summary>The type of the base image dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageDependencyType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="BaseImageDependency" /> instance.</summary>
        public BaseImageDependency()
        {

        }
    }
    /// Properties that describe a base image dependency.
    public partial interface IBaseImageDependency :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The sha256-based digest of the image manifest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sha256-based digest of the image manifest.",
        SerializedName = @"digest",
        PossibleTypes = new [] { typeof(string) })]
        string Digest { get; set; }
        /// <summary>The registry login server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The registry login server.",
        SerializedName = @"registry",
        PossibleTypes = new [] { typeof(string) })]
        string Registry { get; set; }
        /// <summary>The repository name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The repository name.",
        SerializedName = @"repository",
        PossibleTypes = new [] { typeof(string) })]
        string Repository { get; set; }
        /// <summary>The tag name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tag name.",
        SerializedName = @"tag",
        PossibleTypes = new [] { typeof(string) })]
        string Tag { get; set; }
        /// <summary>The type of the base image dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the base image dependency.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageDependencyType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageDependencyType? Type { get; set; }

    }
    /// Properties that describe a base image dependency.
    internal partial interface IBaseImageDependencyInternal

    {
        /// <summary>The sha256-based digest of the image manifest.</summary>
        string Digest { get; set; }
        /// <summary>The registry login server.</summary>
        string Registry { get; set; }
        /// <summary>The repository name.</summary>
        string Repository { get; set; }
        /// <summary>The tag name.</summary>
        string Tag { get; set; }
        /// <summary>The type of the base image dependency.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageDependencyType? Type { get; set; }

    }
}