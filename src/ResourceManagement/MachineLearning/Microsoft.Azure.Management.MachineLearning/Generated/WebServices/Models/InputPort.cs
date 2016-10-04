// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Asset input port
    /// </summary>
    public partial class InputPort
    {
        /// <summary>
        /// Initializes a new instance of the InputPort class.
        /// </summary>
        public InputPort() { }

        /// <summary>
        /// Initializes a new instance of the InputPort class.
        /// </summary>
        /// <param name="type">Port data type. Possible values include:
        /// 'Dataset'</param>
        public InputPort(string type = default(string))
        {
            Type = type;
        }

        /// <summary>
        /// Gets or sets port data type. Possible values include: 'Dataset'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
