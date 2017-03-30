// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using Azure;
    using Management;
    using Batch;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the auto storage account associated with a
    /// Batch account.
    /// </summary>
    public partial class AutoStorageProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class.
        /// </summary>
        public AutoStorageProperties() { }

        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class.
        /// </summary>
        /// <param name="storageAccountId">The resource ID of the storage
        /// account to be used for auto storage account.</param>
        /// <param name="lastKeySync">The UTC time at which storage keys were
        /// last synchronized with the Batch account.</param>
        public AutoStorageProperties(string storageAccountId, System.DateTime lastKeySync)
        {
            StorageAccountId = storageAccountId;
            LastKeySync = lastKeySync;
        }

        /// <summary>
        /// Gets or sets the resource ID of the storage account to be used for
        /// auto storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at which storage keys were last
        /// synchronized with the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "lastKeySync")]
        public System.DateTime LastKeySync { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}

