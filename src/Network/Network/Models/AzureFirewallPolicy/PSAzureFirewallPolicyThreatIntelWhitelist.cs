﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Commands.Network.Models
{
    using System;
    using System.Management.Automation;
    using System.Net;
    using System.Text.RegularExpressions;

    public class PSAzureFirewallPolicyThreatIntelWhitelist
    {
        private string[] fqdns;

        private string[] ipAddresses;

        public string[] FQDNs
        {
            get { return this.fqdns; }
            set
            {
                fqdns = value;
            }
        }

        public string[] IpAddresses
        {
            get { return this.ipAddresses; }
            set
            {
                ipAddresses = value;
            }
        }
    }
}
