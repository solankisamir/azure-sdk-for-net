// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Azure;
    using Management;
    using Insights;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ScaleType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScaleType
    {
        [EnumMember(Value = "ChangeCount")]
        ChangeCount,
        [EnumMember(Value = "PercentChangeCount")]
        PercentChangeCount,
        [EnumMember(Value = "ExactCount")]
        ExactCount
    }
}

