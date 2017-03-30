// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using System.Linq;

    /// <summary>
    /// Provision request specification
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AnalysisServicesServerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AnalysisServicesServerUpdateParameters class.
        /// </summary>
        public AnalysisServicesServerUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AnalysisServicesServerUpdateParameters class.
        /// </summary>
        /// <param name="sku">The SKU of the Analysis Services
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional provisioning
        /// properties.</param>
        public AnalysisServicesServerUpdateParameters(ResourceSku sku = default(ResourceSku), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ServerAdministrators asAdministrators = default(ServerAdministrators), BackupConfiguration backupConfiguration = default(BackupConfiguration))
        {
            Sku = sku;
            Tags = tags;
            AsAdministrators = asAdministrators;
            BackupConfiguration = backupConfiguration;
        }

        /// <summary>
        /// Gets or sets the SKU of the Analysis Services resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of additional provisioning properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.asAdministrators")]
        public ServerAdministrators AsAdministrators { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backupConfiguration")]
        public BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
            if (this.BackupConfiguration != null)
            {
                this.BackupConfiguration.Validate();
            }
        }
    }
}
