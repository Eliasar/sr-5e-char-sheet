using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Quality
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("extra")]
        public string Extra { get; set; }

        [JsonPropertyName("bp")]
        public string Bp { get; set; }

        [JsonPropertyName("qualitytype")]
        public string Qualitytype { get; set; }

        [JsonPropertyName("qualitytype_english")]
        public string QualitytypeEnglish { get; set; }

        [JsonPropertyName("qualitysource")]
        public string Qualitysource { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }
}