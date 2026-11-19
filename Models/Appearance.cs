using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Appearance
    {
        [JsonPropertyName("gender")]
        [JsonProperty("gender")]
        public string Gender { get; set; } = string.Empty;

        [JsonPropertyName("race")]
        [JsonProperty("race")]
        public string Race { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        [JsonProperty("height")]
        public List<string> Height { get; set; } = [];

        [JsonPropertyName("weight")]
        [JsonProperty("weight")]
        public List<string> Weight { get; set; } = [];

        [JsonPropertyName("eye-color")]
        [JsonProperty("eye-color")]
        public string EyeColor { get; set; } = string.Empty;

        [JsonPropertyName("hair-color")]
        [JsonProperty("hair-color")]
        public string HairColor { get; set; } = string.Empty;
    }
}
