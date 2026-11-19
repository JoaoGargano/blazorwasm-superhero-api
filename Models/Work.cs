using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Work
    {
        [JsonPropertyName("occupation")]
        [JsonProperty("occupation")]
        public string Occupation { get; set; } = string.Empty;

        [JsonPropertyName("base")]
        [JsonProperty("base")]
        public string Base { get; set; } = string.Empty;
    }
}
