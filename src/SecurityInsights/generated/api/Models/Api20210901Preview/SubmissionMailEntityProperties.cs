// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Submission mail entity property bag.</summary>
    public partial class SubmissionMailEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties __entityCommonProperties = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityCommonProperties();

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; }

        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; }

        /// <summary>Internal Acessors for AdditionalData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName = value; }

        /// <summary>Internal Acessors for NetworkMessageId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.NetworkMessageId { get => this._networkMessageId; set { {_networkMessageId = value;} } }

        /// <summary>Internal Acessors for Recipient</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.Recipient { get => this._recipient; set { {_recipient = value;} } }

        /// <summary>Internal Acessors for ReportType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.ReportType { get => this._reportType; set { {_reportType = value;} } }

        /// <summary>Internal Acessors for Sender</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.Sender { get => this._sender; set { {_sender = value;} } }

        /// <summary>Internal Acessors for SenderIP</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.SenderIP { get => this._senderIP; set { {_senderIP = value;} } }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.Subject { get => this._subject; set { {_subject = value;} } }

        /// <summary>Internal Acessors for SubmissionDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.SubmissionDate { get => this._submissionDate; set { {_submissionDate = value;} } }

        /// <summary>Internal Acessors for SubmissionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.SubmissionId { get => this._submissionId; set { {_submissionId = value;} } }

        /// <summary>Internal Acessors for Submitter</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.Submitter { get => this._submitter; set { {_submitter = value;} } }

        /// <summary>Internal Acessors for Timestamp</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISubmissionMailEntityPropertiesInternal.Timestamp { get => this._timestamp; set { {_timestamp = value;} } }

        /// <summary>Backing field for <see cref="NetworkMessageId" /> property.</summary>
        private string _networkMessageId;

        /// <summary>The network message id of email to which submission belongs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string NetworkMessageId { get => this._networkMessageId; }

        /// <summary>Backing field for <see cref="Recipient" /> property.</summary>
        private string _recipient;

        /// <summary>The recipient of the mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Recipient { get => this._recipient; }

        /// <summary>Backing field for <see cref="ReportType" /> property.</summary>
        private string _reportType;

        /// <summary>
        /// The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ReportType { get => this._reportType; }

        /// <summary>Backing field for <see cref="Sender" /> property.</summary>
        private string _sender;

        /// <summary>The sender of the mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Sender { get => this._sender; }

        /// <summary>Backing field for <see cref="SenderIP" /> property.</summary>
        private string _senderIP;

        /// <summary>The sender's IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string SenderIP { get => this._senderIP; }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>The subject of submission mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; }

        /// <summary>Backing field for <see cref="SubmissionDate" /> property.</summary>
        private global::System.DateTime? _submissionDate;

        /// <summary>The submission date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? SubmissionDate { get => this._submissionDate; }

        /// <summary>Backing field for <see cref="SubmissionId" /> property.</summary>
        private string _submissionId;

        /// <summary>The submission id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string SubmissionId { get => this._submissionId; }

        /// <summary>Backing field for <see cref="Submitter" /> property.</summary>
        private string _submitter;

        /// <summary>The submitter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Submitter { get => this._submitter; }

        /// <summary>Backing field for <see cref="Timestamp" /> property.</summary>
        private global::System.DateTime? _timestamp;

        /// <summary>The Time stamp when the message is received (Mail)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? Timestamp { get => this._timestamp; }

        /// <summary>Creates an new <see cref="SubmissionMailEntityProperties" /> instance.</summary>
        public SubmissionMailEntityProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityCommonProperties), __entityCommonProperties);
            await eventListener.AssertObjectIsValid(nameof(__entityCommonProperties), __entityCommonProperties);
        }
    }
    /// Submission mail entity property bag.
    public partial interface ISubmissionMailEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties
    {
        /// <summary>The network message id of email to which submission belongs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The network message id of email to which submission belongs",
        SerializedName = @"networkMessageId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkMessageId { get;  }
        /// <summary>The recipient of the mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recipient of the mail",
        SerializedName = @"recipient",
        PossibleTypes = new [] { typeof(string) })]
        string Recipient { get;  }
        /// <summary>
        /// The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.",
        SerializedName = @"reportType",
        PossibleTypes = new [] { typeof(string) })]
        string ReportType { get;  }
        /// <summary>The sender of the mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The sender of the mail",
        SerializedName = @"sender",
        PossibleTypes = new [] { typeof(string) })]
        string Sender { get;  }
        /// <summary>The sender's IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The sender's IP",
        SerializedName = @"senderIp",
        PossibleTypes = new [] { typeof(string) })]
        string SenderIP { get;  }
        /// <summary>The subject of submission mail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The subject of submission mail",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get;  }
        /// <summary>The submission date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The submission date",
        SerializedName = @"submissionDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SubmissionDate { get;  }
        /// <summary>The submission id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The submission id",
        SerializedName = @"submissionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubmissionId { get;  }
        /// <summary>The submitter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The submitter",
        SerializedName = @"submitter",
        PossibleTypes = new [] { typeof(string) })]
        string Submitter { get;  }
        /// <summary>The Time stamp when the message is received (Mail)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Time stamp when the message is received (Mail)",
        SerializedName = @"timestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Timestamp { get;  }

    }
    /// Submission mail entity property bag.
    internal partial interface ISubmissionMailEntityPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal
    {
        /// <summary>The network message id of email to which submission belongs</summary>
        string NetworkMessageId { get; set; }
        /// <summary>The recipient of the mail</summary>
        string Recipient { get; set; }
        /// <summary>
        /// The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.
        /// </summary>
        string ReportType { get; set; }
        /// <summary>The sender of the mail</summary>
        string Sender { get; set; }
        /// <summary>The sender's IP</summary>
        string SenderIP { get; set; }
        /// <summary>The subject of submission mail</summary>
        string Subject { get; set; }
        /// <summary>The submission date</summary>
        global::System.DateTime? SubmissionDate { get; set; }
        /// <summary>The submission id</summary>
        string SubmissionId { get; set; }
        /// <summary>The submitter</summary>
        string Submitter { get; set; }
        /// <summary>The Time stamp when the message is received (Mail)</summary>
        global::System.DateTime? Timestamp { get; set; }

    }
}