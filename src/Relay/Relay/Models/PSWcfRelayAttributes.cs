// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Commands.Relay.Models
{
    using Rest.Serialization;
    using Azure.Management.Relay.Models;

    /// <summary>
    /// Description of WcfRelays Resource.
    /// </summary>
    [JsonTransformation]
    public partial class PSWcfRelayAttributes : PSResourceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the WcfRelay class.
        /// </summary>
        public PSWcfRelayAttributes() { }

        /// <summary>
        /// Initializes a new instance of the WcfRelay class.
        /// </summary>
        /// <param name="wcfRelay"></param>
        public PSWcfRelayAttributes(WcfRelay wcfRelay)
        {
            Id = wcfRelay.Id;
            Name = wcfRelay.Name;
            RelayType = wcfRelay.RelayType.ToString();
            Type = wcfRelay.Type;
            CreatedAt = wcfRelay.CreatedAt;
            UpdatedAt = wcfRelay.UpdatedAt;
            ListenerCount = wcfRelay.ListenerCount;
            RequiresClientAuthorization = wcfRelay.RequiresClientAuthorization;
            RequiresTransportSecurity = wcfRelay.RequiresTransportSecurity;
            IsDynamic = wcfRelay.IsDynamic;
            UserMetadata = wcfRelay.UserMetadata;
        }


        /// <summary>
        /// Gets or sets wCFRelay Type. Possible values include: 'NetTcp',
        /// 'Http'
        /// </summary>
        public string RelayType { get; set; }

        /// <summary>
        /// Gets the time the WCFRelay was created.
        /// </summary>
        public System.DateTime? CreatedAt { get; protected set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        public System.DateTime? UpdatedAt { get; protected set; }

        /// <summary>
        /// Gets the number of listeners for this relay. min : 1 and max:25
        /// supported
        /// </summary>
        public int? ListenerCount { get; protected set; }

        /// <summary>
        /// Gets or sets true if client authorization is needed for this relay;
        /// otherwise, false.
        /// </summary>
        public bool? RequiresClientAuthorization { get; set; }

        /// <summary>
        /// Gets or sets true if transport security is needed for this relay;
        /// otherwise, false.
        /// </summary>
        public bool? RequiresTransportSecurity { get; set; }

        /// <summary>
        /// Gets true if the relay is dynamic; otherwise, false.
        /// </summary>
        public bool? IsDynamic { get; protected set; }

        /// <summary>
        /// Gets or sets usermetadata is a placeholder to store user-defined
        /// string data for the HybridConnection endpoint.e.g. it can be used
        /// to store  descriptive data, such as list of teams and their contact
        /// information also user-defined configuration settings can be stored.
        /// </summary>
        public string UserMetadata { get; set; }

    }
}

