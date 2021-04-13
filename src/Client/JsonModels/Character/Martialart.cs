using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Martialart
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        [JsonPropertyName("martialarttechniques")]
        public Martialarttechniques Martialarttechniques { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }
}