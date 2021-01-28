using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Limitmodifier
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }
}