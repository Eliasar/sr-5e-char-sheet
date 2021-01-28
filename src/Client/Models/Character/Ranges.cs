using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Ranges
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("short")]
        public string Short { get; set; }

        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("extreme")]
        public string Extreme { get; set; }
    }
}