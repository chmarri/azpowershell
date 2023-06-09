﻿//
// Copyright 2012 Microsoft Corporation
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

namespace Microsoft.WindowsAzure.Commands.Storage.Test.Table
{
    using System;
    using global::Azure.Data.Tables.Models;
    using Microsoft.Azure.Cosmos.Table;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
    using Microsoft.WindowsAzure.Commands.Storage.Table;
    using Microsoft.WindowsAzure.Commands.Storage.Test.Service;

    public class StorageTableStorageTestBase : StorageTestBase
    {
        protected MockStorageTableManagement tableMock = null;

        protected const string PolicyName1 = "TestPolicy1";
        protected const string PolicyName2 = "TestPolicy2";
        protected const string PolicyName3 = "TestPolicy3";
        protected const string PolicyName4 = "TestPolicy4";

        protected StorageCloudTableCmdletBase CurrentTableCmd { get; set; }

        [TestInitialize]
        public void InitMock()
        {
            tableMock = new MockStorageTableManagement();
            MockCmdRunTime = new MockCommandRuntime();
        }

        [TestCleanup]
        public void CleanMock()
        {
            tableMock = null;
        }

        public void AddTestTables()
        {
            tableMock.tableList.Clear();
            string testUri = "https://127.0.0.1/account/test";
            string textUri = "https://127.0.0.1/account/text";

            tableMock.tableList.Add(new CloudTable(new Uri(testUri)));
            tableMock.tableList.Add(new CloudTable(new Uri(textUri)));
        }

        public void ClearAndAddTestStoredAccessPolicies()
        {
            DateTime startTime = DateTime.UtcNow;
            DateTime expiryTime = startTime.AddDays(1);

            tableMock.tablePermissions.SharedAccessPolicies.Clear();

            SharedAccessTablePolicy testPolicy1 = new SharedAccessTablePolicy();
            testPolicy1.Permissions = SharedAccessTablePermissions.None;
            testPolicy1.Permissions |= SharedAccessTablePermissions.Query;
            testPolicy1.SharedAccessStartTime = startTime;
            testPolicy1.SharedAccessExpiryTime = expiryTime;
            tableMock.tablePermissions.SharedAccessPolicies.Add(PolicyName1, testPolicy1);

            SharedAccessTablePolicy testPolicy2 = new SharedAccessTablePolicy();
            testPolicy1.Permissions = SharedAccessTablePermissions.None;
            testPolicy1.Permissions |= SharedAccessTablePermissions.Query;
            testPolicy1.SharedAccessStartTime = startTime;
            testPolicy1.SharedAccessExpiryTime = expiryTime;
            tableMock.tablePermissions.SharedAccessPolicies.Add(PolicyName2, testPolicy2);

            tableMock.ClearAndAddTestSignedIdentifiers(
                new Tuple<string, TableAccessPolicy>(PolicyName1, new TableAccessPolicy(startTime, expiryTime, "raud")),
                new Tuple<string, TableAccessPolicy>(PolicyName2, new TableAccessPolicy(startTime, null, "r")),
                new Tuple<string, TableAccessPolicy>(PolicyName3, new TableAccessPolicy(null, expiryTime, "au")),
                new Tuple<string, TableAccessPolicy>(PolicyName4, new TableAccessPolicy(null, null, "aud")));
        }

        protected void clearTest()
        {
            if (tableMock != null)
            {
                tableMock.tableList.Clear();
                tableMock.tablePermissions.SharedAccessPolicies.Clear();

                tableMock.ClearAndAddTestSignedIdentifiers();
                tableMock.ClearAndAddTestTableV2();
            }

            MockCmdRunTime?.ResetPipelines();
        }

        /// <summary>
        /// Run async command
        /// </summary>
        /// <param name="cmd">Storage command</param>
        /// <param name="asyncAction">Async action</param>
        protected void RunAsyncCommand(Action asyncAction)
        {
            MockCmdRunTime.ResetPipelines();
            CurrentTableCmd.SetUpMultiThreadEnvironment();
            asyncAction();
            CurrentTableCmd.MultiThreadEndProcessing();
        }
    }
}