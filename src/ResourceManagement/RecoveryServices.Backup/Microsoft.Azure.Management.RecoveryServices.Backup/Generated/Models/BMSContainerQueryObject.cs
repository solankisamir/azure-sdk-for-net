// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// The query filters that can be used with the list containers API.
    /// </summary>
    public partial class BMSContainerQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSContainerQueryObject class.
        /// </summary>
        public BMSContainerQueryObject() { }

        /// <summary>
        /// Initializes a new instance of the BMSContainerQueryObject class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for this
        /// container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="status">Status of registration of this container with
        /// the Recovery Services Vault.</param>
        /// <param name="friendlyName">Friendly name of this container.</param>
        public BMSContainerQueryObject(BackupManagementType? backupManagementType = default(BackupManagementType?), string status = default(string), string friendlyName = default(string))
        {
            BackupManagementType = backupManagementType;
            Status = status;
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Gets or sets backup management type for this container. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets status of registration of this container with the
        /// Recovery Services Vault.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets friendly name of this container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

    }
}
