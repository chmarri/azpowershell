// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The SKU of a container registry.</summary>
    public partial class Sku :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ISku,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ISkuInternal
    {

        /// <summary>Internal Acessors for Tier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20220201Preview.ISkuInternal.Tier { get => this._tier; set { {_tier = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuName _name;

        /// <summary>The SKU name of the container registry. Required for registry creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuName Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier? _tier;

        /// <summary>The SKU tier based on the SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier? Tier { get => this._tier; }

        /// <summary>Creates an new <see cref="Sku" /> instance.</summary>
        public Sku()
        {

        }
    }
    /// The SKU of a container registry.
    public partial interface ISku :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The SKU name of the container registry. Required for registry creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The SKU name of the container registry. Required for registry creation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuName Name { get; set; }
        /// <summary>The SKU tier based on the SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The SKU tier based on the SKU name.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier? Tier { get;  }

    }
    /// The SKU of a container registry.
    internal partial interface ISkuInternal

    {
        /// <summary>The SKU name of the container registry. Required for registry creation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuName Name { get; set; }
        /// <summary>The SKU tier based on the SKU name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SkuTier? Tier { get; set; }

    }
}