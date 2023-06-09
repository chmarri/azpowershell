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

namespace Microsoft.Azure.Commands.Aks.Models
{
    /// <summary>
    /// A pod identity exception, which allows pods with certain labels to access the
    /// Azure Instance Metadata Service (IMDS) endpoint without being intercepted by
    /// the node-managed identity (NMI) server.
    /// </summary>
    public partial class PSManagedClusterPodIdentityException
    {
        /// <summary>
        /// Gets or sets the name of the pod identity exception.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the namespace of the pod identity exception.
        /// </summary>
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets the pod labels to match.
        /// </summary>
        public IDictionary<string, string> PodLabels { get; set; }
    }
}
