// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of the Storage Endpoint for file upload.
    /// </summary>
    public partial class StorageEndpointProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageEndpointProperties class.
        /// </summary>
        public StorageEndpointProperties() { }

        /// <summary>
        /// Initializes a new instance of the StorageEndpointProperties class.
        /// </summary>
        public StorageEndpointProperties(TimeSpan? sasTtlAsIso8601 = default(TimeSpan?), string connectionString = default(string), string containerName = default(string))
        {
            SasTtlAsIso8601 = sasTtlAsIso8601;
            ConnectionString = connectionString;
            ContainerName = containerName;
        }

        /// <summary>
        /// SAS time to live. Range: 1 Min (PT1M) - 1 Day (P1D).
        /// </summary>
        [JsonProperty(PropertyName = "sasTtlAsIso8601")]
        public TimeSpan? SasTtlAsIso8601 { get; set; }

        /// <summary>
        /// The account key credentials for storage account selected by
        /// customer for uploading files.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The root container name where all files will be uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

    }
}
