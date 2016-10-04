// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [JsonTransformation]
    public partial class VirtualMachineScaleSet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class.
        /// </summary>
        public VirtualMachineScaleSet() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class.
        /// </summary>
        public VirtualMachineScaleSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), UpgradePolicy upgradePolicy = default(UpgradePolicy), VirtualMachineScaleSetVMProfile virtualMachineProfile = default(VirtualMachineScaleSetVMProfile), string provisioningState = default(string), bool? overProvision = default(bool?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            UpgradePolicy = upgradePolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            OverProvision = overProvision;
        }

        /// <summary>
        /// the virtual machine scale set sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// the upgrade policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public UpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// the virtual machine profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineProfile")]
        public VirtualMachineScaleSetVMProfile VirtualMachineProfile { get; set; }

        /// <summary>
        /// the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Specifies whether the Virtual Machine Scale Set should be
        /// overprovisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overProvision")]
        public bool? OverProvision { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.VirtualMachineProfile != null)
            {
                this.VirtualMachineProfile.Validate();
            }
        }
    }
}
