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

namespace Microsoft.Azure.Commands.HPCCache.Test.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Microsoft.Azure.Commands.TestFx;
    using Microsoft.Azure.Test.HttpRecorder;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    /// <summary>
    ///  Test environment utilities.
    /// </summary>
    public static class HpcCacheTestEnvironmentUtilities
    {
        /// <summary>
        /// Connection string that determines how to connect to Azure..
        /// </summary>
        public const string EnvironmentVariableName = "TEST_CSM_ORGID_AUTHENTICATION";

        /// <summary>
        /// Initialize new environment.
        /// </summary>
        public static readonly TestEnvironment Environment =
            new TestEnvironment(System.Environment.GetEnvironmentVariable(EnvironmentVariableName));

        /// <summary>
        /// Gets location.
        /// </summary>
        public static string Location
        {
            get
            {
                return GetValueFromEnvironment("DefaultRegion");
            }
        }

        /// <summary>
        /// Gets resource prefix.
        /// </summary>
        public static string ResourcePrefix
        {
            get
            {
                return GetValueFromEnvironment("DefaultResourcePrefix");
            }
        }

        /// <summary>
        /// Gets cache size.
        /// </summary>
        public static string CacheSize
        {
            get
            {
                return GetValueFromEnvironment("DefaultCacheSize");
            }
        }

        /// <summary>
        /// Gets cache SKU.
        /// </summary>
        public static string CacheSku
        {
            get
            {
                return GetValueFromEnvironment("DefaultCacheSku");
            }
        }

        /// <summary>
        /// Gets resource group name.
        /// </summary>
        public static string ResourceGroupName
        {
            get
            {
                try
                {
                    return GetValueFromEnvironment("ResourceGroupName");
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets cache name.
        /// </summary>
        public static string CacheName
        {
            get
            {
                try
                {
                    return GetValueFromEnvironment("CacheName");
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets cache name.
        /// </summary>
        public static string StorageTargetName
        {
            get
            {
                try
                {
                    return GetValueFromEnvironment("StorageTargetName");
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get subscription id.
        /// </summary>
        /// <returns>Subscription id.</returns>
        public static string SubscriptionId()
        {
            return GetOrAddVariable(
                "SubscriptionId",
                () =>
                {
                    return Environment.SubscriptionId;
                });
        }

        /// <summary>
        /// Gets a variable from HTTP recording (when test is in playback mode) or writes a variable to HTTP recording
        /// (when test is in recording mode).
        /// </summary>
        /// <param name="key">Key that the variable value is stored under in HTTP recording file.</param>
        /// <param name="generateValueFunc">Function that generates the variable value if necessary.</param>
        /// <returns>The variable value.</returns>
        private static string GetOrAddVariable(string key, Func<string> generateValueFunc)
        {
            if (HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                string value = generateValueFunc();
                HttpMockServer.Variables[key] = value;
                return value;
            }
            else
            {
                return HttpMockServer.Variables[key];
            }
        }

        /// <summary>
        /// Get value from test environment.
        /// </summary>
        /// <param name="key">Environment variable key.</param>
        /// <returns>Environment variable.</returns>
        private static string GetValueFromEnvironment(string key)
        {
            return GetOrAddVariable(
                    key,
                    () =>
                    {
                        bool doUseDefaults;
                        Environment.ConnectionString.KeyValuePairs.TryGetValue("useDefaults", out string useDefaults);
                        if (!string.IsNullOrEmpty(useDefaults))
                        {
                            doUseDefaults = bool.Parse(useDefaults);
                        }
                        else
                        {
                            doUseDefaults = false;
                        }

                        Environment.ConnectionString.KeyValuePairs.TryGetValue(key, out string value);

                        if (string.IsNullOrEmpty(value) && doUseDefaults)
                        {
                            if (typeof(Constants).GetField(key) != null)
                            {
                                FieldInfo field = typeof(Constants).GetField(key);

                                value = field.GetValue(null).ToString();
                            }
                        }

                        if (string.IsNullOrEmpty(value))
                        {
                            throw new KeyNotFoundException(
                                string.Format(
                                    "Value for key '{0}' was not found in environment variable '{1}'.", key, EnvironmentVariableName));
                        }

                        return value;
                    });
        }
    }
}