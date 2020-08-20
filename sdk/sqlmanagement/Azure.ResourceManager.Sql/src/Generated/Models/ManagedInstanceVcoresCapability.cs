// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed instance virtual cores capability. </summary>
    public partial class ManagedInstanceVcoresCapability
    {
        /// <summary> Initializes a new instance of ManagedInstanceVcoresCapability. </summary>
        internal ManagedInstanceVcoresCapability()
        {
            SupportedStorageSizes = new ChangeTrackingList<MaxSizeRangeCapability>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceVcoresCapability. </summary>
        /// <param name="name"> The virtual cores identifier. </param>
        /// <param name="value"> The virtual cores value. </param>
        /// <param name="includedMaxSize"> Included size. </param>
        /// <param name="supportedStorageSizes"> Storage size ranges. </param>
        /// <param name="instancePoolSupported"> True if this service objective is supported for managed instances in an instance pool. </param>
        /// <param name="standaloneSupported"> True if this service objective is supported for standalone managed instances. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal ManagedInstanceVcoresCapability(string name, int? value, MaxSizeCapability includedMaxSize, IReadOnlyList<MaxSizeRangeCapability> supportedStorageSizes, bool? instancePoolSupported, bool? standaloneSupported, CapabilityStatus? status, string reason)
        {
            Name = name;
            Value = value;
            IncludedMaxSize = includedMaxSize;
            SupportedStorageSizes = supportedStorageSizes;
            InstancePoolSupported = instancePoolSupported;
            StandaloneSupported = standaloneSupported;
            Status = status;
            Reason = reason;
        }

        /// <summary> The virtual cores identifier. </summary>
        public string Name { get; }
        /// <summary> The virtual cores value. </summary>
        public int? Value { get; }
        /// <summary> Included size. </summary>
        public MaxSizeCapability IncludedMaxSize { get; }
        /// <summary> Storage size ranges. </summary>
        public IReadOnlyList<MaxSizeRangeCapability> SupportedStorageSizes { get; }
        /// <summary> True if this service objective is supported for managed instances in an instance pool. </summary>
        public bool? InstancePoolSupported { get; }
        /// <summary> True if this service objective is supported for standalone managed instances. </summary>
        public bool? StandaloneSupported { get; }
        /// <summary> The status of the capability. </summary>
        public CapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}