using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Power
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("extra")]
        public string Extra { get; set; }

        [JsonPropertyName("pointsperlevel")]
        public string Pointsperlevel { get; set; }

        [JsonPropertyName("adeptway")]
        public string Adeptway { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("totalpoints")]
        public string Totalpoints { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("enhancements")]
        public object Enhancements { get; set; }
    }
}