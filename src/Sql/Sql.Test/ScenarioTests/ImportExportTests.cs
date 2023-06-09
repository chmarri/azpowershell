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

using Microsoft.Azure.Commands.ScenarioTest.SqlTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Sql.Test.ScenarioTests
{
    public class ImportExportTests : SqlTestRunner
    {
        public ImportExportTests(ITestOutputHelper output) : base(output)
        {

        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestExportDatabase()
        {
            TestRunner.RunTestScript("Test-ExportDatabase");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestExportDatabase_NetworkIsolation()
        {
            TestRunner.RunTestScript("Test-ExportDatabaseNetworkIsolation");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Sql, "Needs to be re-recorded")]
        public void TestImportNewDatabase()
        {
            TestRunner.RunTestScript("Test-ImportNewDatabase");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Sql, "Needs to be re-recorded")]
        public void TestImportNewDatabase_NetworkIsolation()
        {
            TestRunner.RunTestScript("Test-ImportNewDatabaseNetworkIsolation");
        }
    }
}
