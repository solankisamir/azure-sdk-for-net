// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class WorkflowParameter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowParameter class.
        /// </summary>
        public WorkflowParameter() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowParameter class.
        /// </summary>
        public WorkflowParameter(ParameterType? type = default(ParameterType?), object value = default(object), object metadata = default(object), string description = default(string))
        {
            Type = type;
            Value = value;
            Metadata = metadata;
            Description = description;
        }

        /// <summary>
        /// Gets or sets gets or sets the type. Possible values include:
        /// 'NotSpecified', 'String', 'SecureString', 'Int', 'Float', 'Bool',
        /// 'Array', 'Object', 'SecureObject'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ParameterType? Type { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
