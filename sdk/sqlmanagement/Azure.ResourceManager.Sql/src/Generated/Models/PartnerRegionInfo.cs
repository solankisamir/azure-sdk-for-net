// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Partner region information for the failover group. </summary>
    public partial class PartnerRegionInfo
    {
        /// <summary> Initializes a new instance of PartnerRegionInfo. </summary>
        public PartnerRegionInfo()
        {
        }

        /// <summary> Initializes a new instance of PartnerRegionInfo. </summary>
        /// <param name="location"> Geo location of the partner managed instances. </param>
        /// <param name="replicationRole"> Replication role of the partner managed instances. </param>
        internal PartnerRegionInfo(string location, InstanceFailoverGroupReplicationRole? replicationRole)
        {
            Location = location;
            ReplicationRole = replicationRole;
        }

        /// <summary> Geo location of the partner managed instances. </summary>
        public string Location { get; set; }
        /// <summary> Replication role of the partner managed instances. </summary>
        public InstanceFailoverGroupReplicationRole? ReplicationRole { get; }
    }
}