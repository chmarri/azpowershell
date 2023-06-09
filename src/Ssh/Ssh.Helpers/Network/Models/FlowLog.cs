// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A flow log resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FlowLog : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FlowLog class.
        /// </summary>
        public FlowLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlowLog class.
        /// </summary>
        /// <param name="targetResourceId">ID of network security group to
        /// which flow log will be applied.</param>
        /// <param name="storageId">ID of the storage account which is used to
        /// store the flow log.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="targetResourceGuid">Guid of network security group to
        /// which flow log will be applied.</param>
        /// <param name="enabled">Flag to enable/disable flow logging.</param>
        /// <param name="retentionPolicy">Parameters that define the retention
        /// policy for flow log.</param>
        /// <param name="format">Parameters that define the flow log
        /// format.</param>
        /// <param name="flowAnalyticsConfiguration">Parameters that define the
        /// configuration of traffic analytics.</param>
        /// <param name="provisioningState">The provisioning state of the flow
        /// log. Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public FlowLog(string targetResourceId, string storageId, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string targetResourceGuid = default(string), bool? enabled = default(bool?), RetentionPolicyParameters retentionPolicy = default(RetentionPolicyParameters), FlowLogFormatParameters format = default(FlowLogFormatParameters), TrafficAnalyticsProperties flowAnalyticsConfiguration = default(TrafficAnalyticsProperties), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            TargetResourceId = targetResourceId;
            TargetResourceGuid = targetResourceGuid;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            Format = format;
            FlowAnalyticsConfiguration = flowAnalyticsConfiguration;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of network security group to which flow log will be
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets guid of network security group to which flow log will be
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceGuid")]
        public string TargetResourceGuid { get; private set; }

        /// <summary>
        /// Gets or sets ID of the storage account which is used to store the
        /// flow log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// Gets or sets flag to enable/disable flow logging.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets parameters that define the retention policy for flow
        /// log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicyParameters RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets parameters that define the flow log format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.format")]
        public FlowLogFormatParameters Format { get; set; }

        /// <summary>
        /// Gets or sets parameters that define the configuration of traffic
        /// analytics.
        /// </summary>
        [JsonProperty(PropertyName = "properties.flowAnalyticsConfiguration")]
        public TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }

        /// <summary>
        /// Gets the provisioning state of the flow log. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (StorageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageId");
            }
        }
    }
}
