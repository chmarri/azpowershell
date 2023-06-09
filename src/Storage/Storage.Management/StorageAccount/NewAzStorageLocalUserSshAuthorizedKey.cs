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

using Microsoft.Azure.Commands.Management.Storage.Models;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Management.Storage
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "StorageLocalUserSshPublicKey"), OutputType(typeof(PSSshPublicKey))]
    public class NewAzureStorageLocalUserSshPublicKeyCommand : StorageAccountBaseCmdlet
    {
        [Parameter(Mandatory = true,
            HelpMessage = "Specify ssh public key, which is base64 encoded. The format should be: '<keyType> <keyData>', e.g. ssh-rsa AAAABBBB")]
        [ValidateNotNull]
        public string Key { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "The description of the key. It is used to store the function/usage of the key.")]
        [ValidateNotNull]
        public string Description { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            PSSshPublicKey key = new PSSshPublicKey()
            {
                Key = this.Key,
                Description = this.Description
            };

            WriteObject(key);
        }
    }
}
