// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class BatchEndpointTrackedResourceArmPaginatedResult
    {
        internal static BatchEndpointTrackedResourceArmPaginatedResult DeserializeBatchEndpointTrackedResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BatchEndpointData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BatchEndpointData> array = new List<BatchEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchEndpointData.DeserializeBatchEndpointData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BatchEndpointTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
