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

using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Commands.OperationalInsights.Models
{
    public class PSSavedSearchValue
    {
        public PSSavedSearchValue()
        {
        }

        public PSSavedSearchValue(SavedSearch v)
        {
            if (v != null)
            {
                this.Id = v.Id;
                this.Name = v.Name;
                this.Type = v.Type;
                this.ETag = v.Etag;
                this.Properties = new PSSavedSearchProperties(v);
            }
        }
        public string Id { get; set; }
        public string ETag { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public PSSavedSearchProperties Properties { get; set; }
    }
}
