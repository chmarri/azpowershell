// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Inner error</summary>
    public partial class InnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IInnerError,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IInnerErrorInternal
    {

        /// <summary>Backing field for <see cref="Diagnosticcontext" /> property.</summary>
        private string _diagnosticcontext;

        /// <summary>Provides correlation for request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Diagnosticcontext { get => this._diagnosticcontext; set => this._diagnosticcontext = value; }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private global::System.DateTime? _time;

        /// <summary>Request time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? Time { get => this._time; set => this._time = value; }

        /// <summary>Creates an new <see cref="InnerError" /> instance.</summary>
        public InnerError()
        {

        }
    }
    /// Inner error
    public partial interface IInnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Provides correlation for request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides correlation for request",
        SerializedName = @"diagnosticcontext",
        PossibleTypes = new [] { typeof(string) })]
        string Diagnosticcontext { get; set; }
        /// <summary>Request time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request time",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Time { get; set; }

    }
    /// Inner error
    internal partial interface IInnerErrorInternal

    {
        /// <summary>Provides correlation for request</summary>
        string Diagnosticcontext { get; set; }
        /// <summary>Request time</summary>
        global::System.DateTime? Time { get; set; }

    }
}