using System;
using LibreTranslate.Net.Enhanced.Constants;
using Newtonsoft.Json;

namespace LibreTranslate.Net.Enhanced.Serialization
{
    internal class LanguageCodeConverter : JsonConverter<LanguageCode>
    {
        public override void WriteJson(JsonWriter writer, LanguageCode value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        public override LanguageCode ReadJson(JsonReader reader, Type objectType, LanguageCode existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return reader.Value as string;
        }
    }
}