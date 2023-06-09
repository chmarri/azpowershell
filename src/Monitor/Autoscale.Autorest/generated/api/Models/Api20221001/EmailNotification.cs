// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Extensions;

    /// <summary>Email notification of an autoscale event.</summary>
    public partial class EmailNotification :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IEmailNotification,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.IEmailNotificationInternal
    {

        /// <summary>Backing field for <see cref="CustomEmail" /> property.</summary>
        private string[] _customEmail;

        /// <summary>
        /// the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.PropertyOrigin.Owned)]
        public string[] CustomEmail { get => this._customEmail; set => this._customEmail = value; }

        /// <summary>Backing field for <see cref="SendToSubscriptionAdministrator" /> property.</summary>
        private bool? _sendToSubscriptionAdministrator;

        /// <summary>a value indicating whether to send email to subscription administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.PropertyOrigin.Owned)]
        public bool? SendToSubscriptionAdministrator { get => this._sendToSubscriptionAdministrator; set => this._sendToSubscriptionAdministrator = value; }

        /// <summary>Backing field for <see cref="SendToSubscriptionCoAdministrator" /> property.</summary>
        private bool? _sendToSubscriptionCoAdministrator;

        /// <summary>a value indicating whether to send email to subscription co-administrators.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.PropertyOrigin.Owned)]
        public bool? SendToSubscriptionCoAdministrator { get => this._sendToSubscriptionCoAdministrator; set => this._sendToSubscriptionCoAdministrator = value; }

        /// <summary>Creates an new <see cref="EmailNotification" /> instance.</summary>
        public EmailNotification()
        {

        }
    }
    /// Email notification of an autoscale event.
    public partial interface IEmailNotification :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.IJsonSerializable
    {
        /// <summary>
        /// the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.",
        SerializedName = @"customEmails",
        PossibleTypes = new [] { typeof(string) })]
        string[] CustomEmail { get; set; }
        /// <summary>a value indicating whether to send email to subscription administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"a value indicating whether to send email to subscription administrator.",
        SerializedName = @"sendToSubscriptionAdministrator",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SendToSubscriptionAdministrator { get; set; }
        /// <summary>a value indicating whether to send email to subscription co-administrators.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"a value indicating whether to send email to subscription co-administrators.",
        SerializedName = @"sendToSubscriptionCoAdministrators",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SendToSubscriptionCoAdministrator { get; set; }

    }
    /// Email notification of an autoscale event.
    internal partial interface IEmailNotificationInternal

    {
        /// <summary>
        /// the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.
        /// </summary>
        string[] CustomEmail { get; set; }
        /// <summary>a value indicating whether to send email to subscription administrator.</summary>
        bool? SendToSubscriptionAdministrator { get; set; }
        /// <summary>a value indicating whether to send email to subscription co-administrators.</summary>
        bool? SendToSubscriptionCoAdministrator { get; set; }

    }
}