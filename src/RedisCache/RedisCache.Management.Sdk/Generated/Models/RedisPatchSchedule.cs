// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisCache.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response to put/get patch schedules for Redis cache.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RedisPatchSchedule : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RedisPatchSchedule class.
        /// </summary>
        public RedisPatchSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisPatchSchedule class.
        /// </summary>
        /// <param name="scheduleEntries">List of patch schedules for a Redis
        /// cache.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        public RedisPatchSchedule(IList<ScheduleEntry> scheduleEntries, string id = default(string), string name = default(string), string type = default(string), string location = default(string))
            : base(id, name, type)
        {
            ScheduleEntries = scheduleEntries;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of patch schedules for a Redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scheduleEntries")]
        public IList<ScheduleEntry> ScheduleEntries { get; set; }

        /// <summary>
        /// Gets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScheduleEntries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScheduleEntries");
            }
            if (ScheduleEntries != null)
            {
                foreach (var element in ScheduleEntries)
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
