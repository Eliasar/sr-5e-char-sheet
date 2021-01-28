using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Alternateranges
    {
        [JsonPropertyName("name")]
        public object Name { get; set; }

        [JsonPropertyName("short")]
        public object Short { get; set; }

        [JsonPropertyName("medium")]
        public object Medium { get; set; }

        [JsonPropertyName("long")]
        public object Long { get; set; }

        [JsonPropertyName("extreme")]
        public object Extreme { get; set; }
    }
}