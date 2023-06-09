// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Defines the valid editions of Azure SQL Databases. See MSDN for more
    /// information.
    /// </summary>
    public static partial class DatabaseEditions
    {
        /// <summary>
        /// The Web Edition Database is best suited for small Web applications
        /// and workgroup or departmental applications.
        /// </summary>
        public const string Web = "Web";

        /// <summary>
        /// The Business Edition Database is best suited for independent
        /// software vendors (ISVs), line-of-business (LOB) applications, and
        /// enterprise applications.
        /// </summary>
        public const string Business = "Business";

        /// <summary>
        /// The Basic Edition Database is best suited for small databases with
        /// few transactions (&lt;100) per minute and only a couple users.
        /// </summary>
        public const string Basic = "Basic";

        /// <summary>
        /// The Standard Edition Database is best suited for a group of users
        /// makingfewer than 1000 transactions per minute.
        /// </summary>
        public const string Standard = "Standard";

        /// <summary>
        /// The Premium Edition Database is for situations requiring a high
        /// number of transactionsper second (&gt;100).  Supports more users than
        /// Basic and Standard editions.
        /// </summary>
        public const string Premium = "Premium";

        /// <summary>
        /// The Free Edition Database is available for certain offers and
        /// product bundles.
        /// </summary>
        public const string Free = "Free";
    }
}
