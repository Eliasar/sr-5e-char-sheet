using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Skillspecialization
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("free")]
        public string Free { get; set; }

        [JsonPropertyName("expertise")]
        public string Expertise { get; set; }

        [JsonPropertyName("specbonus")]
        public string Specbonus { get; set; }
    }
}