using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Biography
    {
        [JsonPropertyName("full-name")]
        [JsonProperty("full-name")]
        public string FullName { get; set; } = string.Empty;

        [JsonPropertyName("alter-egos")]
        [JsonProperty("alter-egos")]
        public string AlterEgos { get; set; } = string.Empty;

        [JsonPropertyName("aliases")]
        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; } = [];

        [JsonPropertyName("place-of-birth")]
        [JsonProperty("place-of-birth")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [JsonPropertyName("first-appearance")]
        [JsonProperty("first-appearance")]
        public string FirstAppearance { get; set; } = string.Empty;

        [JsonPropertyName("publisher")]
        [JsonProperty("publisher")]
        public string Publisher { get; set; } = string.Empty;

        [JsonPropertyName("alignment")]
        [JsonProperty("alignment")]
        public string Alignment { get; set; } = string.Empty;
    }
}
