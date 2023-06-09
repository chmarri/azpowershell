// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of virtual machine patch operations.
    /// </summary>
    public partial class VirtualMachinePatchStatus
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachinePatchStatus class.
        /// </summary>
        public VirtualMachinePatchStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachinePatchStatus class.
        /// </summary>
        /// <param name="availablePatchSummary">The available patch summary of
        /// the latest assessment operation for the virtual machine.</param>
        /// <param name="lastPatchInstallationSummary">The installation summary
        /// of the latest installation operation for the virtual
        /// machine.</param>
        /// <param name="configurationStatuses">The enablement status of the
        /// specified patchMode</param>
        public VirtualMachinePatchStatus(AvailablePatchSummary availablePatchSummary = default(AvailablePatchSummary), LastPatchInstallationSummary lastPatchInstallationSummary = default(LastPatchInstallationSummary), IList<InstanceViewStatus> configurationStatuses = default(IList<InstanceViewStatus>))
        {
            AvailablePatchSummary = availablePatchSummary;
            LastPatchInstallationSummary = lastPatchInstallationSummary;
            ConfigurationStatuses = configurationStatuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the available patch summary of the latest assessment
        /// operation for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "availablePatchSummary")]
        public AvailablePatchSummary AvailablePatchSummary { get; set; }

        /// <summary>
        /// Gets or sets the installation summary of the latest installation
        /// operation for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "lastPatchInstallationSummary")]
        public LastPatchInstallationSummary LastPatchInstallationSummary { get; set; }

        /// <summary>
        /// Gets the enablement status of the specified patchMode
        /// </summary>
        [JsonProperty(PropertyName = "configurationStatuses")]
        public IList<InstanceViewStatus> ConfigurationStatuses { get; private set; }

    }
}
