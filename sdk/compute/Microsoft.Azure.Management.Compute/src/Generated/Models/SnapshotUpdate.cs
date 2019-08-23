// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Snapshot update resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SnapshotUpdate
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotUpdate class.
        /// </summary>
        public SnapshotUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SnapshotUpdate class.
        /// </summary>
        /// <param name="osType">the Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the disk to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="encryptionSettingsCollection">Encryption settings
        /// collection used be Azure Disk Encryption, can contain multiple
        /// encryption settings per disk or snapshot.</param>
        /// <param name="tags">Resource tags</param>
        public SnapshotUpdate(OperatingSystemTypes? osType = default(OperatingSystemTypes?), int? diskSizeGB = default(int?), EncryptionSettingsCollection encryptionSettingsCollection = default(EncryptionSettingsCollection), IDictionary<string, string> tags = default(IDictionary<string, string>), SnapshotSku sku = default(SnapshotSku))
        {
            OsType = osType;
            DiskSizeGB = diskSizeGB;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            Tags = tags;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the disk to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets encryption settings collection used be Azure Disk
        /// Encryption, can contain multiple encryption settings per disk or
        /// snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SnapshotSku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionSettingsCollection != null)
            {
                EncryptionSettingsCollection.Validate();
            }
        }
    }
}
