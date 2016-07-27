// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Holds the available configuration options for an Azure ML web service
    /// endpoint.
    /// </summary>
    public partial class RealtimeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the RealtimeConfiguration class.
        /// </summary>
        public RealtimeConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the RealtimeConfiguration class.
        /// </summary>
        public RealtimeConfiguration(int? maxConcurrentCalls = default(int?))
        {
            MaxConcurrentCalls = maxConcurrentCalls;
        }

        /// <summary>
        /// Maximum number of concurrent calls allowed on the realtime
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "maxConcurrentCalls")]
        public int? MaxConcurrentCalls { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.MaxConcurrentCalls > 200)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxConcurrentCalls", 200);
            }
            if (this.MaxConcurrentCalls < 4)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxConcurrentCalls", 4);
            }
        }
    }
}
