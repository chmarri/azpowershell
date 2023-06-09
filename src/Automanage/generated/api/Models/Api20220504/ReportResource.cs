// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Extensions;

    /// <summary>Details about the resource processed by the configuration profile assignment</summary>
    public partial class ReportResource :
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResource,
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail _error;

        /// <summary>Error message, if any, returned when deploying the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.ErrorDetail()); }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.ErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Target = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20220504.IReportResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetailInternal)Error).Target; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ReportResource" /> instance.</summary>
        public ReportResource()
        {

        }
    }
    /// Details about the resource processed by the configuration profile assignment
    public partial interface IReportResource :
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail[] Detail { get;  }
        /// <summary>ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ARM id of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the resource.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Details about the resource processed by the configuration profile assignment
    internal partial interface IReportResourceInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail[] Detail { get; set; }
        /// <summary>Error message, if any, returned when deploying the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.Api20.IErrorDetail Error { get; set; }
        /// <summary>ARM id of the resource.</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>Name of the resource.</summary>
        string Name { get; set; }
        /// <summary>Status of the resource.</summary>
        string Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }
        /// <summary>Type of the resource.</summary>
        string Type { get; set; }

    }
}