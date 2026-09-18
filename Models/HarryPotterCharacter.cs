using System.Text.Json.Serialization;

namespace ChuckNorris.Models
{
    public partial class HarryPotterCharacter
    {
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        [JsonPropertyName("hogwartsHouse")]
        public string HogwartsHouse { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("birthdate")]
        public string Birthdate { get; set; }
    }
}