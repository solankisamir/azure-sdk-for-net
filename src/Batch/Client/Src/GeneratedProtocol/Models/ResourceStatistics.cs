// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Statistics related to resource consumption by compute nodes in a pool.
    /// </summary>
    public partial class ResourceStatistics
    {
        /// <summary>
        /// Initializes a new instance of the ResourceStatistics class.
        /// </summary>
        public ResourceStatistics() { }

        /// <summary>
        /// Initializes a new instance of the ResourceStatistics class.
        /// </summary>
        /// <param name="startTime">The start time of the time range covered
        /// by the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="avgCPUPercentage">The average CPU usage across all
        /// nodes in the pool (percentage per node).</param>
        /// <param name="avgMemoryGiB">The average memory usage in GiB across
        /// all nodes in the pool.</param>
        /// <param name="peakMemoryGiB">The peak memory usage in GiB across
        /// all nodes in the pool.</param>
        /// <param name="avgDiskGiB">The average used disk space in GiB across
        /// all nodes in the pool.</param>
        /// <param name="peakDiskGiB">The peak used disk space in GiB across
        /// all nodes in the pool.</param>
        /// <param name="diskReadIOps">The total number of disk read
        /// operations across all nodes in the pool.</param>
        /// <param name="diskWriteIOps">The total number of disk write
        /// operations across all nodes in the pool.</param>
        /// <param name="diskReadGiB">The total amount of data in GiB of disk
        /// reads across all nodes in the pool.</param>
        /// <param name="diskWriteGiB">The total amount of data in GiB of disk
        /// writes across all nodes in the pool.</param>
        /// <param name="networkReadGiB">The total amount of data in GiB of
        /// network reads across all nodes in the pool.</param>
        /// <param name="networkWriteGiB">The total amount of data in GiB of
        /// network writes across all nodes in the pool.</param>
        public ResourceStatistics(System.DateTime startTime, System.DateTime lastUpdateTime, double avgCPUPercentage, double avgMemoryGiB, double peakMemoryGiB, double avgDiskGiB, double peakDiskGiB, long diskReadIOps, long diskWriteIOps, double diskReadGiB, double diskWriteGiB, double networkReadGiB, double networkWriteGiB)
        {
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            AvgCPUPercentage = avgCPUPercentage;
            AvgMemoryGiB = avgMemoryGiB;
            PeakMemoryGiB = peakMemoryGiB;
            AvgDiskGiB = avgDiskGiB;
            PeakDiskGiB = peakDiskGiB;
            DiskReadIOps = diskReadIOps;
            DiskWriteIOps = diskWriteIOps;
            DiskReadGiB = diskReadGiB;
            DiskWriteGiB = diskWriteGiB;
            NetworkReadGiB = networkReadGiB;
            NetworkWriteGiB = networkWriteGiB;
        }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the average CPU usage across all nodes in the pool
        /// (percentage per node).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "avgCPUPercentage")]
        public double AvgCPUPercentage { get; set; }

        /// <summary>
        /// Gets or sets the average memory usage in GiB across all nodes in
        /// the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "avgMemoryGiB")]
        public double AvgMemoryGiB { get; set; }

        /// <summary>
        /// Gets or sets the peak memory usage in GiB across all nodes in the
        /// pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "peakMemoryGiB")]
        public double PeakMemoryGiB { get; set; }

        /// <summary>
        /// Gets or sets the average used disk space in GiB across all nodes
        /// in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "avgDiskGiB")]
        public double AvgDiskGiB { get; set; }

        /// <summary>
        /// Gets or sets the peak used disk space in GiB across all nodes in
        /// the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "peakDiskGiB")]
        public double PeakDiskGiB { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk read operations across all
        /// nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskReadIOps")]
        public long DiskReadIOps { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk write operations across all
        /// nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskWriteIOps")]
        public long DiskWriteIOps { get; set; }

        /// <summary>
        /// Gets or sets the total amount of data in GiB of disk reads across
        /// all nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskReadGiB")]
        public double DiskReadGiB { get; set; }

        /// <summary>
        /// Gets or sets the total amount of data in GiB of disk writes across
        /// all nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskWriteGiB")]
        public double DiskWriteGiB { get; set; }

        /// <summary>
        /// Gets or sets the total amount of data in GiB of network reads
        /// across all nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkReadGiB")]
        public double NetworkReadGiB { get; set; }

        /// <summary>
        /// Gets or sets the total amount of data in GiB of network writes
        /// across all nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkWriteGiB")]
        public double NetworkWriteGiB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
