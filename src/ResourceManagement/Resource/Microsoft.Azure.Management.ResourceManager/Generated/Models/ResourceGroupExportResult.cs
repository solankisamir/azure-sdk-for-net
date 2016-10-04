// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class ResourceGroupExportResult
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupExportResult class.
        /// </summary>
        public ResourceGroupExportResult() { }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupExportResult class.
        /// </summary>
        public ResourceGroupExportResult(object template = default(object), ResourceManagementErrorWithDetails error = default(ResourceManagementErrorWithDetails))
        {
            Template = template;
            Error = error;
        }

        /// <summary>
        /// The template content.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// The error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ResourceManagementErrorWithDetails Error { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Error != null)
            {
                this.Error.Validate();
            }
        }
    }
}
