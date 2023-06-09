// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Extensions;

    /// <summary>Recommendation resource metadata</summary>
    public partial class ResourceMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataAction _action;

        /// <summary>The action to view resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataAction Action { get => (this._action = this._action ?? new Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.ResourceMetadataAction()); set => this._action = value; }

        /// <summary>Backing field for <see cref="Plural" /> property.</summary>
        private string _plural;

        /// <summary>The plural user friendly name of resource type. eg: virtual machines</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Plural { get => this._plural; set => this._plural = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Azure resource Id of the assessed resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="Singular" /> property.</summary>
        private string _singular;

        /// <summary>The singular user friendly name of resource type. eg: virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Singular { get => this._singular; set => this._singular = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Source from which recommendation is generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Creates an new <see cref="ResourceMetadata" /> instance.</summary>
        public ResourceMetadata()
        {

        }
    }
    /// Recommendation resource metadata
    public partial interface IResourceMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IJsonSerializable
    {
        /// <summary>The action to view resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action to view resource.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataAction Action { get; set; }
        /// <summary>The plural user friendly name of resource type. eg: virtual machines</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The plural user friendly name of resource type. eg: virtual machines",
        SerializedName = @"plural",
        PossibleTypes = new [] { typeof(string) })]
        string Plural { get; set; }
        /// <summary>Azure resource Id of the assessed resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource Id of the assessed resource",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>The singular user friendly name of resource type. eg: virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The singular user friendly name of resource type. eg: virtual machine",
        SerializedName = @"singular",
        PossibleTypes = new [] { typeof(string) })]
        string Singular { get; set; }
        /// <summary>Source from which recommendation is generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source from which recommendation is generated",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }

    }
    /// Recommendation resource metadata
    internal partial interface IResourceMetadataInternal

    {
        /// <summary>The action to view resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceMetadataAction Action { get; set; }
        /// <summary>The plural user friendly name of resource type. eg: virtual machines</summary>
        string Plural { get; set; }
        /// <summary>Azure resource Id of the assessed resource</summary>
        string ResourceId { get; set; }
        /// <summary>The singular user friendly name of resource type. eg: virtual machine</summary>
        string Singular { get; set; }
        /// <summary>Source from which recommendation is generated</summary>
        string Source { get; set; }

    }
}