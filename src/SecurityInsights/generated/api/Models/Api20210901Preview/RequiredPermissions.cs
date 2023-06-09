// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Required permissions for the connector</summary>
    public partial class RequiredPermissions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IRequiredPermissions,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IRequiredPermissionsInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private bool? _action;

        /// <summary>action permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="Delete" /> property.</summary>
        private bool? _delete;

        /// <summary>delete permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Delete { get => this._delete; set => this._delete = value; }

        /// <summary>Backing field for <see cref="Read" /> property.</summary>
        private bool? _read;

        /// <summary>read permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Read { get => this._read; set => this._read = value; }

        /// <summary>Backing field for <see cref="Write" /> property.</summary>
        private bool? _write;

        /// <summary>write permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Write { get => this._write; set => this._write = value; }

        /// <summary>Creates an new <see cref="RequiredPermissions" /> instance.</summary>
        public RequiredPermissions()
        {

        }
    }
    /// Required permissions for the connector
    public partial interface IRequiredPermissions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>action permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"action permission",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Action { get; set; }
        /// <summary>delete permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delete permission",
        SerializedName = @"delete",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Delete { get; set; }
        /// <summary>read permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"read permission",
        SerializedName = @"read",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Read { get; set; }
        /// <summary>write permission</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"write permission",
        SerializedName = @"write",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Write { get; set; }

    }
    /// Required permissions for the connector
    internal partial interface IRequiredPermissionsInternal

    {
        /// <summary>action permission</summary>
        bool? Action { get; set; }
        /// <summary>delete permission</summary>
        bool? Delete { get; set; }
        /// <summary>read permission</summary>
        bool? Read { get; set; }
        /// <summary>write permission</summary>
        bool? Write { get; set; }

    }
}