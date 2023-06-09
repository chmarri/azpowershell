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

using Microsoft.Azure.Commands.Subscription.Test.ScenarioTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Subscription.Test.ScenarioTests
{
    /// <summary>
    /// The following tests require four subscriptions to be created manually. This can be done by 
    /// calling New-AzureRmSubscription. At this time, this can only be done by EA customers.
    /// </summary>
    public class SubscriptionTests : SubscriptionTestRunner
    {
        public SubscriptionTests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateRenameSubscription()
        {
            TestRunner.RunTestScript("Test-UpdateRenameSubscription");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateCancelSubscription()
        {
            TestRunner.RunTestScript("Test-UpdateCancelSubscription");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewSubscriptionAlias()
        {
            TestRunner.RunTestScript("Test-NewSubscriptionAlias");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetSubscriptionAlias()
        {
            TestRunner.RunTestScript("Test-GetSubscriptionAlias");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveSubscriptionAlias()
        {
            TestRunner.RunTestScript("Test-RemoveSubscriptionAlias");
        }
    }
}
