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

namespace Microsoft.Azure.Commands.TestFx
{
    public enum TestEnvironmentName
    {
        Prod,
        Dogfood,
        Next,
        Current,
        Custom
    }

    public class Variables
    {
        public const string SubscriptionId = "SubscriptionId";

        public const string TenantId = "TenantId";

        public const string Username = "Username";
    }
}

namespace Microsoft.WindowsAzure.Commands.ScenarioTest
{
    public class Category
    {
        public const string Service = "Service";

        public const string All = "All";

        public const string Automation = "Automation";

        public const string ServiceBus = "ServiceBus";

        public const string CloudService = "CloudService";

        public const string Management = "Management";

        public const string MediaServices = "MediaServices";

        public const string Websites = "Websites";

        public const string Storage = "Storage";

        public const string Store = "Store";

        public const string Sql = "Sql";

        public const string ServiceManagement = "ServiceManagement";

        public const string Resources = "Resources";

        public const string Tags = "Tags";

        public const string TrafficManager = "TrafficManager";

        public const string Scheduler = "Scheduler";

        public const string KeyVault = "KeyVault";

        public const string Network = "Network";

        public const string Owner = "Owner";

        public const string OneSDK = "OneSDK";

        public const string AcceptanceType = "AcceptanceType";

        public const string CIT = "CIT";

        public const string BVT = "BVT";

        public const string CheckIn = "CheckIn";

        public const string Flaky = "Flaky";

        public const string RunType = "RunType";

        public const string CoreOnly = "CoreOnly";

        public const string DesktopOnly = "DesktopOnly";

        public const string LiveOnly = "LiveOnly";

        public const string Environment = "Environment";

        public const string WAPack = "WAPack";
    }
}

namespace Microsoft.Rest.ClientRuntime.Azure.TestFramework
{
    public static class TestTraits
    {
        public const string AcceptanceType = "AcceptanceType";

        public const string CheckIn = "CheckIn";

        public const string LiveBVT = "LiveBVT";

        public const string MockedBVT = "MockedBVT";
    }
}
