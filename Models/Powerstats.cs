using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Powerstats
    {
        [JsonPropertyName("intelligence")]
        [JsonProperty("intelligence")]
        public string Intelligence { get; set; } = string.Empty;

        [JsonPropertyName("strength")]
        [JsonProperty("strength")]
        public string Strength { get; set; } = string.Empty;

        [JsonPropertyName("speed")]
        [JsonProperty("speed")]
        public string Speed { get; set; } = string.Empty;

        [JsonPropertyName("durability")]
        [JsonProperty("durability")]
        public string Durability { get; set; } = string.Empty;

        [JsonPropertyName("power")]
        [JsonProperty("power")]
        public string Power { get; set; } = string.Empty;

        [JsonPropertyName("combat")]
        [JsonProperty("combat")]
        public string Combat { get; set; } = string.Empty;
    }
}
