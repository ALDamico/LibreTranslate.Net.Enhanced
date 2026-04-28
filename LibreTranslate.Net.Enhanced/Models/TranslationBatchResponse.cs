using System.Collections.Generic;
using Newtonsoft.Json;

namespace LibreTranslate.Net.Enhanced.Models
{
    /// <summary>
    /// The model for the batch translation api response
    /// </summary>
    public class TranslationBatchResponse
    {
        internal TranslationBatchResponse() {}

        [JsonProperty("translatedText")]
        public List<string> TranslatedText { get; set; } = new List<string>();
        [JsonProperty("error")] 
        public string Error { get; set; }
    }
}