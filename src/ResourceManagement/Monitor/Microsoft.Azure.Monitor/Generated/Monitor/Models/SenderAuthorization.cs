// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using Azure;
    using Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The RBAC properties of the event.
    /// </summary>
    public partial class SenderAuthorization
    {
        /// <summary>
        /// Initializes a new instance of the SenderAuthorization class.
        /// </summary>
        public SenderAuthorization() { }

        /// <summary>
        /// Initializes a new instance of the SenderAuthorization class.
        /// </summary>
        /// <param name="action">the permissible actions. For instance:
        /// microsoft.support/supporttickets/write</param>
        /// <param name="role">the role of the user. For instance: Subscription
        /// Admin</param>
        /// <param name="scope">the scope.</param>
        public SenderAuthorization(string action = default(string), string role = default(string), string scope = default(string))
        {
            Action = action;
            Role = role;
            Scope = scope;
        }

        /// <summary>
        /// Gets or sets the permissible actions. For instance:
        /// microsoft.support/supporttickets/write
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the role of the user. For instance: Subscription Admin
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

    }
}

