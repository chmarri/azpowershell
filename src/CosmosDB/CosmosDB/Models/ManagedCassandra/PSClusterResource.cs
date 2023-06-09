﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    using System.Collections.Generic;
    using Microsoft.Azure.Management.CosmosDB.Models;

    public class PSClusterResource
    {
        public PSClusterResource()
        {
        }        
        
        public PSClusterResource(ClusterResource clusterResource)
        {
            if (clusterResource == null)
                return;
            
            Id = clusterResource.Id;
            Name = clusterResource.Name;
            Location = clusterResource.Location;
            Tags = clusterResource.Tags;
            Properties = new PSClusterResourceProperties(clusterResource.Properties);
        }

        /// <summary>
        /// Gets or sets Id of the Managed Cassandra Cluster
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name of the Managed Cassandra Cluster
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Location of the Managed Cassandra Cluster
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Tags of the Managed Cassandra Cluster
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        public PSClusterResourceProperties Properties { get; set; }
    }
}
