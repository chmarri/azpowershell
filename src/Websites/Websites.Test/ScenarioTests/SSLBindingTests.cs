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


using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Websites.Test.ScenarioTests
{
    public class SSLBindingTests : WebsitesTestRunner
    {
        public SSLBindingTests(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateNewWebAppSSLBinding()
        {
            TestRunner.RunTestScript("Test-CreateNewWebAppSSLBinding");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetNewWebAppSSLBinding()
        {
            TestRunner.RunTestScript("Test-GetNewWebAppSSLBinding");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveNewWebAppSSLBinding()
        {
            TestRunner.RunTestScript("Test-RemoveNewWebAppSSLBinding");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestWebAppSSLBindingPipeSupport()
        {
            TestRunner.RunTestScript("Test-WebAppSSLBindingPipeSupport");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebAppCertificate()
        {
            TestRunner.RunTestScript("Test-GetWebAppCertificate");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TagsNotRemovedByCreateNewWebAppSSLBinding()
        {
            TestRunner.RunTestScript("Test-TagsNotRemovedByCreateNewWebAppSSLBinding");
        }
    }
}
