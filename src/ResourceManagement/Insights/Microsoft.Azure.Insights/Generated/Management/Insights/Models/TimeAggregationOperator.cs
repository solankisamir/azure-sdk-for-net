// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{

    /// <summary>
    /// Defines values for TimeAggregationOperator.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeAggregationOperator
    {
        [System.Runtime.Serialization.EnumMember(Value = "Average")]
        Average,
        [System.Runtime.Serialization.EnumMember(Value = "Minimum")]
        Minimum,
        [System.Runtime.Serialization.EnumMember(Value = "Maximum")]
        Maximum,
        [System.Runtime.Serialization.EnumMember(Value = "Total")]
        Total,
        [System.Runtime.Serialization.EnumMember(Value = "Last")]
        Last
    }
}
