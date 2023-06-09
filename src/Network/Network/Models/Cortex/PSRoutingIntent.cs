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

namespace Microsoft.Azure.Commands.Network.Models
{
    using System.Collections.Generic;
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using Newtonsoft.Json;

    public class PSRoutingIntent : PSChildResource
    {
        [Ps1Xml(Label = "Provisioning State", Target = ViewControl.Table)]
        public string ProvisioningState { get; set; }

        [Ps1Xml(Label = "Routing Policies", Target = ViewControl.Table)]
        public List<PSRoutingPolicy> RoutingPolicies { get; set; }

        [JsonIgnore]
        public string RoutingPoliciesText
        {
            get { return JsonConvert.SerializeObject(RoutingPolicies, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }
    }

    public class PSRoutingPolicy
    {
        [Ps1Xml(Label = "Name", Target = ViewControl.Table)]
        public string Name { get; set; }

        public string DestinationType
        {
            get
            {
                return "TrafficType";
            }
        }

        [Ps1Xml(Label = "Destinations", Target = ViewControl.Table)]
        public List<string> Destinations { get; set; }

        public string NextHopType
        {
            get
            {
                return "ResourceId";
            }
        }

        [Ps1Xml(Label = "Next Hop", Target = ViewControl.Table)]
        public string NextHop { get; set; }
    }
}
