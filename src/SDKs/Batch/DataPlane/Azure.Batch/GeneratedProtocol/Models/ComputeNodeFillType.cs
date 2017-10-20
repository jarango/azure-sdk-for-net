// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ComputeNodeFillType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComputeNodeFillType
    {
        [EnumMember(Value = "spread")]
        Spread,
        [EnumMember(Value = "pack")]
        Pack
    }
    internal static class ComputeNodeFillTypeEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeFillType? value)
        {
            return value == null ? null : ((ComputeNodeFillType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ComputeNodeFillType value)
        {
            switch( value )
            {
                case ComputeNodeFillType.Spread:
                    return "spread";
                case ComputeNodeFillType.Pack:
                    return "pack";
            }
            return null;
        }

        internal static ComputeNodeFillType? ParseComputeNodeFillType(this string value)
        {
            switch( value )
            {
                case "spread":
                    return ComputeNodeFillType.Spread;
                case "pack":
                    return ComputeNodeFillType.Pack;
            }
            return null;
        }
    }
}