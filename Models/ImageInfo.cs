using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class ImageInfo
    {
        [JsonPropertyName("url")]
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;
    }
}
