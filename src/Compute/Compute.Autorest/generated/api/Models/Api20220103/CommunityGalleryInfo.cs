// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Information of community gallery if current gallery is shared to community</summary>
    public partial class CommunityGalleryInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ICommunityGalleryInfo,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ICommunityGalleryInfoInternal
    {

        /// <summary>Backing field for <see cref="CommunityGalleryEnabled" /> property.</summary>
        private bool? _communityGalleryEnabled;

        /// <summary>Contains info about whether community gallery sharing is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public bool? CommunityGalleryEnabled { get => this._communityGalleryEnabled; }

        /// <summary>Backing field for <see cref="Eula" /> property.</summary>
        private string _eula;

        /// <summary>End-user license agreement for community gallery image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Eula { get => this._eula; set => this._eula = value; }

        /// <summary>Internal Acessors for CommunityGalleryEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ICommunityGalleryInfoInternal.CommunityGalleryEnabled { get => this._communityGalleryEnabled; set { {_communityGalleryEnabled = value;} } }

        /// <summary>Internal Acessors for PublicName</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.ICommunityGalleryInfoInternal.PublicName { get => this._publicName; set { {_publicName = value;} } }

        /// <summary>Backing field for <see cref="PublicName" /> property.</summary>
        private string[] _publicName;

        /// <summary>Community gallery public name list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string[] PublicName { get => this._publicName; }

        /// <summary>Backing field for <see cref="PublicNamePrefix" /> property.</summary>
        private string _publicNamePrefix;

        /// <summary>
        /// The prefix of the gallery name that will be displayed publicly. Visible to all users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string PublicNamePrefix { get => this._publicNamePrefix; set => this._publicNamePrefix = value; }

        /// <summary>Backing field for <see cref="PublisherContact" /> property.</summary>
        private string _publisherContact;

        /// <summary>
        /// Community gallery publisher support email. The email address of the publisher. Visible to all users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string PublisherContact { get => this._publisherContact; set => this._publisherContact = value; }

        /// <summary>Backing field for <see cref="PublisherUri" /> property.</summary>
        private string _publisherUri;

        /// <summary>The link to the publisher website. Visible to all users.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string PublisherUri { get => this._publisherUri; set => this._publisherUri = value; }

        /// <summary>Creates an new <see cref="CommunityGalleryInfo" /> instance.</summary>
        public CommunityGalleryInfo()
        {

        }
    }
    /// Information of community gallery if current gallery is shared to community
    public partial interface ICommunityGalleryInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>Contains info about whether community gallery sharing is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Contains info about whether community gallery sharing is enabled.",
        SerializedName = @"communityGalleryEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CommunityGalleryEnabled { get;  }
        /// <summary>End-user license agreement for community gallery image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End-user license agreement for community gallery image.",
        SerializedName = @"eula",
        PossibleTypes = new [] { typeof(string) })]
        string Eula { get; set; }
        /// <summary>Community gallery public name list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Community gallery public name list.",
        SerializedName = @"publicNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] PublicName { get;  }
        /// <summary>
        /// The prefix of the gallery name that will be displayed publicly. Visible to all users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The prefix of the gallery name that will be displayed publicly. Visible to all users.",
        SerializedName = @"publicNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string PublicNamePrefix { get; set; }
        /// <summary>
        /// Community gallery publisher support email. The email address of the publisher. Visible to all users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Community gallery publisher support email. The email address of the publisher. Visible to all users.",
        SerializedName = @"publisherContact",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherContact { get; set; }
        /// <summary>The link to the publisher website. Visible to all users.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to the publisher website. Visible to all users.",
        SerializedName = @"publisherUri",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherUri { get; set; }

    }
    /// Information of community gallery if current gallery is shared to community
    internal partial interface ICommunityGalleryInfoInternal

    {
        /// <summary>Contains info about whether community gallery sharing is enabled.</summary>
        bool? CommunityGalleryEnabled { get; set; }
        /// <summary>End-user license agreement for community gallery image.</summary>
        string Eula { get; set; }
        /// <summary>Community gallery public name list.</summary>
        string[] PublicName { get; set; }
        /// <summary>
        /// The prefix of the gallery name that will be displayed publicly. Visible to all users.
        /// </summary>
        string PublicNamePrefix { get; set; }
        /// <summary>
        /// Community gallery publisher support email. The email address of the publisher. Visible to all users.
        /// </summary>
        string PublisherContact { get; set; }
        /// <summary>The link to the publisher website. Visible to all users.</summary>
        string PublisherUri { get; set; }

    }
}