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

using System;

namespace Microsoft.Azure.Commands.Resources.Models.Authorization
{
    public class PSRoleAssignment
    {
        public string RoleAssignmentName { get; set; }

        public string RoleAssignmentId { get; set; }

        public string Scope { get; set; }

        public string DisplayName { get; set; }

        public string SignInName { get; set; }

        public string RoleDefinitionName { get; set; }

        public string RoleDefinitionId { get; set; }

        public string ObjectId { get; set; }

        public string ObjectType { get; set; }

        public bool CanDelegate { get; set; }

        public string Description { get; set; }

        public string ConditionVersion { get; set; }

        public string Condition { get; set; }
    }
}
