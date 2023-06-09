﻿//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Commands
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Management.Automation;
    using System.Security.Cryptography.X509Certificates;
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Models;
    using Properties;

    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApiManagementCertificate", DefaultParameterSetName = FromFile)]
    [OutputType(typeof(PsApiManagementCertificate))]
    public class NewAzureApiManagementCertificate : AzureApiManagementCmdletBase
    {
        private const string FromFile = "LoadFromFile";
        private const string Raw = "Raw";

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Identifier of new certificate. This parameter is optional. If not specified will be generated.")]
        public String CertificateId { get; set; }

        [Parameter(
            ParameterSetName = FromFile,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Path to the certificate file in .pfx format to be created/uploaded. This parameter is required if -PfxBytes not specified.")]
        public String PfxFilePath { get; set; }

        [Parameter(
            ParameterSetName = Raw,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Bytes of the certificate file in .pfx format to be created/uploaded. This parameter is required if -PfxFilePath not specified.")]
        public Byte[] PfxBytes { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Password for the certificate. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public String PfxPassword { get; set; }

        [Parameter(
             ValueFromPipelineByPropertyName = true,
             Mandatory = false,
             HelpMessage = "KeyVault used to fetch certificate data." +
                          "This parameter is required if -PfxFilePath not specified.")]
        public PsApiManagementKeyVaultEntity KeyVault { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            var certificateId = CertificateId ?? Guid.NewGuid().ToString("N");
            PsApiManagementCertificate certificate;

            if (KeyVault != null)
            {
                certificate = Client.CertificateCreate(Context, certificateId, null, null, KeyVault);

            }
            else
            {
                byte[] rawBytes;

                if (ParameterSetName.Equals(FromFile))
                {
                    FileInfo localFile = new FileInfo(this.GetUnresolvedProviderPathFromPSPath(this.PfxFilePath));
                    if (!localFile.Exists)
                    {
                        throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture, Resources.SourceFileNotFound, PfxFilePath));
                    }

                    using (var certStream = File.OpenRead(localFile.FullName))
                    {
                        rawBytes = new byte[certStream.Length];
                        certStream.Read(rawBytes, 0, rawBytes.Length);
                    }
                }
                else if (ParameterSetName.Equals(Raw))
                {
                    rawBytes = PfxBytes;
                }
                else
                {
                    throw new InvalidOperationException(string.Format("Parameter set name '{0}' is not supported.", ParameterSetName));
                }

                // check for valid certificate file/bytes
                new X509Certificate2(rawBytes, PfxPassword);

                certificate = Client.CertificateCreate(Context, certificateId, rawBytes, PfxPassword);
            }
            WriteObject(certificate);
        }
    }
}
