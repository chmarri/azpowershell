// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Extensions;

    /// <summary>An Azure resource object.</summary>
    public partial class AzureResource :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResource,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>
        /// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always
        /// be 'global'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceTags _tag;

        /// <summary>The tags of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.AzureResourceTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="AzureResource" /> instance.</summary>
        public AzureResource()
        {

        }
    }
    /// An Azure resource object.
    public partial interface IAzureResource :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.IJsonSerializable
    {
        /// <summary>The resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always
        /// be 'global'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always be 'global'.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The tags of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags of the resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceTags Tag { get; set; }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An Azure resource object.
    internal partial interface IAzureResourceInternal

    {
        /// <summary>The resource Id.</summary>
        string Id { get; set; }
        /// <summary>
        /// The location of the resource. Since Azure Activity Log Alerts is a global service, the location of the rules should always
        /// be 'global'.
        /// </summary>
        string Location { get; set; }
        /// <summary>The name of the resource.</summary>
        string Name { get; set; }
        /// <summary>The tags of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IAzureResourceTags Tag { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}