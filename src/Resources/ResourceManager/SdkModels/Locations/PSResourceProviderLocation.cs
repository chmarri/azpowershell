// ----------------------------------------------------------------------------------
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

using System.Collections.Generic;
using Microsoft.Azure.Management.ResourceManager.Models;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels
{
    /// <summary>
    /// Represents the location with supported providers
    /// </summary>
    public class PSResourceProviderLocation
    {
        /// <summary>
        /// Gets or sets the location name
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the location display name
        /// </summary>
        public string DisplayName { get; set; }

        public LocationType? Type { get;set; }


        public string Longitude { get;set; }

        public string Latitude { get;set; }

        public string PhysicalLocation { get;set; }

        public string RegionType { get;set; }

        public string RegionCategory { get;set; }

        public string GeographyGroup { get;set; }

        public IList<PairedRegion> PairedRegion { get; set; }

        /// <summary>
        /// Gets or sets the providers that are supported in this location
        /// </summary>
        public List<string> Providers { get; set; }
    }
}
