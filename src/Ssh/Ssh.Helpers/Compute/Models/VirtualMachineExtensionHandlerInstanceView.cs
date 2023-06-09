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
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine extension handler.
    /// </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionHandlerInstanceView class.
        /// </summary>
        public VirtualMachineExtensionHandlerInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionHandlerInstanceView class.
        /// </summary>
        /// <param name="type">Specifies the type of the extension; an example
        /// is "CustomScriptExtension".</param>
        /// <param name="typeHandlerVersion">Specifies the version of the
        /// script handler.</param>
        /// <param name="status">The extension handler status.</param>
        public VirtualMachineExtensionHandlerInstanceView(string type = default(string), string typeHandlerVersion = default(string), InstanceViewStatus status = default(InstanceViewStatus))
        {
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the type of the extension; an example is
        /// "CustomScriptExtension".
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets specifies the version of the script handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets the extension handler status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InstanceViewStatus Status { get; set; }

    }
}
