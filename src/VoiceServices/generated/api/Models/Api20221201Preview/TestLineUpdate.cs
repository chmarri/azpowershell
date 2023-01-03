// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Extensions;

    /// <summary>The type used for update operations of the TestLine.</summary>
    public partial class TestLineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.TestLineUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="TestLineUpdate" /> instance.</summary>
        public TestLineUpdate()
        {

        }
    }
    /// The type used for update operations of the TestLine.
    public partial interface ITestLineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateTags Tag { get; set; }

    }
    /// The type used for update operations of the TestLine.
    internal partial interface ITestLineUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ITestLineUpdateTags Tag { get; set; }

    }
}