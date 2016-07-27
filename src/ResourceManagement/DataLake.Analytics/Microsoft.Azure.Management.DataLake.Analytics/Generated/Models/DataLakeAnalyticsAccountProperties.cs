// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The account specific properties that are associated with an underlying
    /// Data Lake Analytics account.
    /// </summary>
    public partial class DataLakeAnalyticsAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountProperties class.
        /// </summary>
        public DataLakeAnalyticsAccountProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountProperties class.
        /// </summary>
        public DataLakeAnalyticsAccountProperties(DataLakeAnalyticsAccountStatus? provisioningState = default(DataLakeAnalyticsAccountStatus?), DataLakeAnalyticsAccountState? state = default(DataLakeAnalyticsAccountState?), string defaultDataLakeStoreAccount = default(string), int? maxDegreeOfParallelism = default(int?), int? maxJobCount = default(int?), IList<DataLakeStoreAccountInfo> dataLakeStoreAccounts = default(IList<DataLakeStoreAccountInfo>), IList<StorageAccountInfo> storageAccounts = default(IList<StorageAccountInfo>), DateTime? creationTime = default(DateTime?), DateTime? lastModifiedTime = default(DateTime?), string endpoint = default(string))
        {
            ProvisioningState = provisioningState;
            State = state;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            MaxJobCount = maxJobCount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
        }

        /// <summary>
        /// Gets the provisioning status of the Data Lake Analytics account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public DataLakeAnalyticsAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Analytics account. Possible values
        /// include: 'active', 'suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public DataLakeAnalyticsAccountState? State { get; private set; }

        /// <summary>
        /// Gets or sets the default data lake storage account associated with
        /// this Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// acocunt.
        /// </summary>
        [JsonProperty(PropertyName = "maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the list of Data Lake storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "dataLakeStoreAccounts")]
        public IList<DataLakeStoreAccountInfo> DataLakeStoreAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Blob storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccounts")]
        public IList<StorageAccountInfo> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; private set; }

    }
}
