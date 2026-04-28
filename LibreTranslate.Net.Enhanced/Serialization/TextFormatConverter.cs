using System;
using LibreTranslate.Net.Enhanced.Constants;
using Newtonsoft.Json;

namespace LibreTranslate.Net.Enhanced.Serialization
{
    internal class TextFormatConverter : JsonConverter<TextFormat>
    {
        public override void WriteJson(JsonWriter writer, TextFormat value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        public override TextFormat ReadJson(JsonReader reader, Type objectType, TextFormat existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            return reader.Value as string;
        }
    }
}