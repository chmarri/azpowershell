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
    /// Output of virtual machine capture operation.
    /// </summary>
    public partial class VirtualMachineCaptureResult : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        public VirtualMachineCaptureResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResult
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="schema">the schema of the captured virtual
        /// machine</param>
        /// <param name="contentVersion">the version of the content</param>
        /// <param name="parameters">parameters of the captured virtual
        /// machine</param>
        /// <param name="resources">a list of resource items of the captured
        /// virtual machine</param>
        public VirtualMachineCaptureResult(string id = default(string), string schema = default(string), string contentVersion = default(string), object parameters = default(object), IList<object> resources = default(IList<object>))
            : base(id)
        {
            Schema = schema;
            ContentVersion = contentVersion;
            Parameters = parameters;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the schema of the captured virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "$schema")]
        public string Schema { get; private set; }

        /// <summary>
        /// Gets the version of the content
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; private set; }

        /// <summary>
        /// Gets parameters of the captured virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; private set; }

        /// <summary>
        /// Gets a list of resource items of the captured virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<object> Resources { get; private set; }

    }
}
