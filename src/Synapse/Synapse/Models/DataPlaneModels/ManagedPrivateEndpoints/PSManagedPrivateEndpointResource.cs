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

using Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class PSManagedPrivateEndpointResource 
    {
        public PSManagedPrivateEndpointResource(ManagedPrivateEndpoint managedPrivateEndpoint, string workspaceName)
        {
            this.WorkspaceName = workspaceName;
            this.Id = managedPrivateEndpoint?.Id;
            this.Name = managedPrivateEndpoint?.Name;
            this.Type = managedPrivateEndpoint?.Type;
            this.Properties = managedPrivateEndpoint?.Properties != null? new PSManagedPrivateEndpointProperties(managedPrivateEndpoint.Properties) : null;
        }

        public string WorkspaceName { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get;  set; }

        public PSManagedPrivateEndpointProperties Properties { get;  set; }
    }
}
