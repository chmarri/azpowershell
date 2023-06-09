// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for a task run request.
    /// </summary>
    [Newtonsoft.Json.JsonObject("TaskRunRequest")]
    public partial class TaskRunRequest : RunRequest
    {
        /// <summary>
        /// Initializes a new instance of the TaskRunRequest class.
        /// </summary>
        public TaskRunRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskRunRequest class.
        /// </summary>
        /// <param name="taskName">The name of task against which run has to be
        /// queued.</param>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled for the run or not.</param>
        /// <param name="values">The collection of overridable values that can
        /// be passed when running a task.</param>
        public TaskRunRequest(string taskName, bool? isArchiveEnabled = default(bool?), IList<SetValue> values = default(IList<SetValue>))
            : base(isArchiveEnabled)
        {
            TaskName = taskName;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of task against which run has to be queued.
        /// </summary>
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or sets the collection of overridable values that can be
        /// passed when running a task.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<SetValue> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskName");
            }
            if (Values != null)
            {
                foreach (var element in Values)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
