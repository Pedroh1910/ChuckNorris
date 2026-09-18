using System.Text.Json.Serialization;

namespace ChuckNorris.Models
{
    public partial class ChuckNorrisJoke
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}