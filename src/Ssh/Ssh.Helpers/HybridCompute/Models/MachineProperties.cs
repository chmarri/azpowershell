// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.HybridCompute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a hybrid machine.
    /// </summary>
    public partial class MachineProperties
    {
        /// <summary>
        /// Initializes a new instance of the MachineProperties class.
        /// </summary>
        public MachineProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachineProperties class.
        /// </summary>
        /// <param name="osProfile">Specifies the operating system settings for
        /// the hybrid machine.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="status">The status of the hybrid machine agent.
        /// Possible values include: 'Connected', 'Disconnected',
        /// 'Error'</param>
        /// <param name="lastStatusChange">The time of the last status
        /// change.</param>
        /// <param name="errorDetails">Details about the error state.</param>
        /// <param name="agentVersion">The hybrid machine agent full
        /// version.</param>
        /// <param name="vmId">Specifies the hybrid machine unique ID.</param>
        /// <param name="displayName">Specifies the hybrid machine display
        /// name.</param>
        /// <param name="machineFqdn">Specifies the hybrid machine
        /// FQDN.</param>
        /// <param name="clientPublicKey">Public Key that the client provides
        /// to be used during initial resource onboarding</param>
        /// <param name="osName">The Operating System running on the hybrid
        /// machine.</param>
        /// <param name="osVersion">The version of Operating System running on
        /// the hybrid machine.</param>
        /// <param name="vmUuid">Specifies the Arc Machine's unique SMBIOS
        /// ID</param>
        /// <param name="extensions">Machine Extensions information</param>
        /// <param name="osSku">Specifies the Operating System product
        /// SKU.</param>
        /// <param name="domainName">Specifies the Windows domain name.</param>
        /// <param name="adFqdn">Specifies the AD fully qualified display
        /// name.</param>
        /// <param name="dnsFqdn">Specifies the DNS fully qualified display
        /// name.</param>
        public MachineProperties(LocationData locationData = default(LocationData), MachinePropertiesOsProfile osProfile = default(MachinePropertiesOsProfile), string provisioningState = default(string), string status = default(string), System.DateTime? lastStatusChange = default(System.DateTime?), IList<ErrorDetail> errorDetails = default(IList<ErrorDetail>), string agentVersion = default(string), string vmId = default(string), string displayName = default(string), string machineFqdn = default(string), string clientPublicKey = default(string), string osName = default(string), string osVersion = default(string), string vmUuid = default(string), IList<MachineExtensionInstanceView> extensions = default(IList<MachineExtensionInstanceView>), string osSku = default(string), string domainName = default(string), string adFqdn = default(string), string dnsFqdn = default(string))
        {
            LocationData = locationData;
            OsProfile = osProfile;
            ProvisioningState = provisioningState;
            Status = status;
            LastStatusChange = lastStatusChange;
            ErrorDetails = errorDetails;
            AgentVersion = agentVersion;
            VmId = vmId;
            DisplayName = displayName;
            MachineFqdn = machineFqdn;
            ClientPublicKey = clientPublicKey;
            OsName = osName;
            OsVersion = osVersion;
            VmUuid = vmUuid;
            Extensions = extensions;
            OsSku = osSku;
            DomainName = domainName;
            AdFqdn = adFqdn;
            DnsFqdn = dnsFqdn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationData")]
        public LocationData LocationData { get; set; }

        /// <summary>
        /// Gets or sets specifies the operating system settings for the hybrid
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public MachinePropertiesOsProfile OsProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the hybrid machine agent. Possible values
        /// include: 'Connected', 'Disconnected', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time of the last status change.
        /// </summary>
        [JsonProperty(PropertyName = "lastStatusChange")]
        public System.DateTime? LastStatusChange { get; private set; }

        /// <summary>
        /// Gets details about the error state.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<ErrorDetail> ErrorDetails { get; private set; }

        /// <summary>
        /// Gets the hybrid machine agent full version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; private set; }

        /// <summary>
        /// Gets or sets specifies the hybrid machine unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets specifies the hybrid machine display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets specifies the hybrid machine FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "machineFqdn")]
        public string MachineFqdn { get; private set; }

        /// <summary>
        /// Gets or sets public Key that the client provides to be used during
        /// initial resource onboarding
        /// </summary>
        [JsonProperty(PropertyName = "clientPublicKey")]
        public string ClientPublicKey { get; set; }

        /// <summary>
        /// Gets the Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; private set; }

        /// <summary>
        /// Gets the version of Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; private set; }

        /// <summary>
        /// Gets specifies the Arc Machine's unique SMBIOS ID
        /// </summary>
        [JsonProperty(PropertyName = "vmUuid")]
        public string VmUuid { get; private set; }

        /// <summary>
        /// Gets machine Extensions information
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<MachineExtensionInstanceView> Extensions { get; private set; }

        /// <summary>
        /// Gets specifies the Operating System product SKU.
        /// </summary>
        [JsonProperty(PropertyName = "osSku")]
        public string OsSku { get; private set; }

        /// <summary>
        /// Gets specifies the Windows domain name.
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; private set; }

        /// <summary>
        /// Gets specifies the AD fully qualified display name.
        /// </summary>
        [JsonProperty(PropertyName = "adFqdn")]
        public string AdFqdn { get; private set; }

        /// <summary>
        /// Gets specifies the DNS fully qualified display name.
        /// </summary>
        [JsonProperty(PropertyName = "dnsFqdn")]
        public string DnsFqdn { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LocationData != null)
            {
                LocationData.Validate();
            }
            if (ErrorDetails != null)
            {
                foreach (var element in ErrorDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
