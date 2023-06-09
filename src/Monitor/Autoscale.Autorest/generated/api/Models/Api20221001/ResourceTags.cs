// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>
    /// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this
    /// resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater
    /// in length than 128 characters and a value no greater in length than 256 characters.
    /// </summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this
    /// resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater
    /// in length than 128 characters and a value no greater in length than 256 characters.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this
    /// resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater
    /// in length than 128 characters and a value no greater in length than 256 characters.
    internal partial interface IResourceTagsInternal

    {

    }
}