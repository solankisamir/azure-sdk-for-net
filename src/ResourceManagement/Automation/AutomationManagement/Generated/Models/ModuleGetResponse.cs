// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the get module operation.
    /// </summary>
    public partial class ModuleGetResponse : AzureOperationResponse
    {
        private Module _module;
        
        /// <summary>
        /// Optional. Gets or sets a module.
        /// </summary>
        public Module Module
        {
            get { return this._module; }
            set { this._module = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ModuleGetResponse class.
        /// </summary>
        public ModuleGetResponse()
        {
        }
    }
}
