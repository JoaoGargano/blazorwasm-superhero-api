using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHero
    {
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("powerstats")]
        [JsonProperty("powerstats")]
        public Powerstats Powerstats { get; set; } = new();

        [JsonPropertyName("biography")]
        [JsonProperty("biography")]
        public Biography Biography { get; set; } = new();

        [JsonPropertyName("appearance")]
        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; } = new();

        [JsonPropertyName("work")]
        [JsonProperty("work")]
        public Work Work { get; set; } = new();

        [JsonPropertyName("connections")]
        [JsonProperty("connections")]
        public Connections Connections { get; set; } = new();

        [JsonPropertyName("image")]
        [JsonProperty("image")]
        public ImageInfo Image { get; set; } = new();
    }
}
