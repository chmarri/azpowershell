// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Error details</summary>
    public partial class InnerErrorTrace :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IInnerErrorTrace,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IInnerErrorTraceInternal
    {

        /// <summary>Internal Acessors for Trace</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IInnerErrorTraceInternal.Trace { get => this._trace; set { {_trace = value;} } }

        /// <summary>Backing field for <see cref="Trace" /> property.</summary>
        private string[] _trace;

        /// <summary>detailed error trace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string[] Trace { get => this._trace; }

        /// <summary>Creates an new <see cref="InnerErrorTrace" /> instance.</summary>
        public InnerErrorTrace()
        {

        }
    }
    /// Error details
    public partial interface IInnerErrorTrace :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>detailed error trace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"detailed error trace",
        SerializedName = @"trace",
        PossibleTypes = new [] { typeof(string) })]
        string[] Trace { get;  }

    }
    /// Error details
    internal partial interface IInnerErrorTraceInternal

    {
        /// <summary>detailed error trace</summary>
        string[] Trace { get; set; }

    }
}