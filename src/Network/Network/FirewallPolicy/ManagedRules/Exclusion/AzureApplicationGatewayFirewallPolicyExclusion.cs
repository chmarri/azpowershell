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

using Microsoft.Azure.Commands.Network.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    public class AzureApplicationGatewayFirewallPolicyExclusion : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "MatchVariable on Exclusion entry.")]
        [ValidateSet("RequestHeaderNames", "RequestCookieNames", "RequestArgNames", "RequestHeaderKeys", "RequestCookieKeys", "RequestArgKeys", "RequestHeaderValues", "RequestCookieValues", "RequestArgValues", IgnoreCase = true)]
        [ValidateNotNullOrEmpty]
        public string MatchVariable { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Selector Match Operator.")]
        [ValidateSet("Equals", "Contains", "StartsWith", "EndsWith", "EqualsAny", IgnoreCase = true)]
        [ValidateNotNullOrEmpty]
        public string SelectorMatchOperator { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Selector")]
        public string Selector { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "List of Exclusion Managed ruleSets.")]
        [ValidateNotNullOrEmpty]
        public PSApplicationGatewayFirewallPolicyExclusionManagedRuleSet[] ExclusionManagedRuleSet { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
        }

        protected PSApplicationGatewayFirewallPolicyExclusion NewObject()
        {
            return new PSApplicationGatewayFirewallPolicyExclusion()
            {
                MatchVariable = this.MatchVariable,
                SelectorMatchOperator = this.SelectorMatchOperator,
                Selector = this.Selector,
                ExclusionManagedRuleSets = this.ExclusionManagedRuleSet?.ToList()
            };
        }
    }
}
