// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>
    /// Object that includes an array of Service Registry resources and a possible link for next set
    /// </summary>
    public partial class ServiceRegistryResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResource[] _value;

        /// <summary>Collection of Service Registry resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ServiceRegistryResourceCollection" /> instance.</summary>
        public ServiceRegistryResourceCollection()
        {

        }
    }
    /// Object that includes an array of Service Registry resources and a possible link for next set
    public partial interface IServiceRegistryResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL client should use to fetch the next page (per server side paging).
        It's null for now, added for future use.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of Service Registry resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of Service Registry resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResource[] Value { get; set; }

    }
    /// Object that includes an array of Service Registry resources and a possible link for next set
    internal partial interface IServiceRegistryResourceCollectionInternal

    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Collection of Service Registry resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResource[] Value { get; set; }

    }
}