// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsDataSerialization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(EventSerializationType.ToString());
            writer.WriteEndObject();
        }

        internal static StreamAnalyticsDataSerialization DeserializeStreamAnalyticsDataSerialization(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Avro": return AvroFormatSerialization.DeserializeAvroFormatSerialization(element);
                    case "Csv": return CsvFormatSerialization.DeserializeCsvFormatSerialization(element);
                    case "CustomClr": return CustomClrFormatSerialization.DeserializeCustomClrFormatSerialization(element);
                    case "Json": return JsonFormatSerialization.DeserializeJsonFormatSerialization(element);
                    case "Parquet": return ParquetFormatSerialization.DeserializeParquetFormatSerialization(element);
                }
            }
            EventSerializationType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new EventSerializationType(property.Value.GetString());
                    continue;
                }
            }
            return new StreamAnalyticsDataSerialization(type);
        }
    }
}
