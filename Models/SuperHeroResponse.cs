using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHeroResponse
    {
        [JsonPropertyName("response")]
        [JsonProperty("response")]
        public string Response { get; set; } = string.Empty;

        [JsonPropertyName("results-for")]
        [JsonProperty("results-for")]
        public string ResultsFor { get; set; } = string.Empty;

        [JsonPropertyName("results")]
        [JsonProperty("results")]
        public List<SuperHero>? Results { get; set; }

        [JsonPropertyName("error")]
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
