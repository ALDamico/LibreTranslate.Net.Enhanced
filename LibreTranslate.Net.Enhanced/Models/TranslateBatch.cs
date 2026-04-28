using System.Collections.Generic;
using LibreTranslate.Net.Enhanced.Constants;
using LibreTranslate.Net.Enhanced.Serialization;
using Newtonsoft.Json;

namespace LibreTranslate.Net.Enhanced.Models
{
    public class TranslateBatch
    {
        /// <summary>
        /// The text to be translated
        /// </summary>
        [JsonProperty("q")]
        public List<string> Text { get; set; }
        /// <summary>
        /// The source of the current language text
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(LanguageCodeConverter))]
        public LanguageCode Source { get; set; }
        /// <summary>
        /// The target of the language we want to convert text
        /// </summary>
        [JsonProperty("target")]
        [JsonConverter(typeof(LanguageCodeConverter))]
        public LanguageCode Target { get; set; }
        /// <summary>
        /// The libre translate api key
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        /// <summary>
        /// Indicates whether the q payload is plain text or Html
        /// </summary>
        [JsonProperty("format")] 
        [JsonConverter(typeof(TextFormatConverter))]
        public TextFormat Format { get; set; }
    }
}