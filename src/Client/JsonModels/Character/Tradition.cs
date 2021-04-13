using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Tradition
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("istechnomancertradition")]
        public string Istechnomancertradition { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("extra")]
        public object Extra { get; set; }

        [JsonPropertyName("spiritcombat")]
        public string Spiritcombat { get; set; }

        [JsonPropertyName("spiritdetection")]
        public string Spiritdetection { get; set; }

        [JsonPropertyName("spirithealth")]
        public string Spirithealth { get; set; }

        [JsonPropertyName("spiritillusion")]
        public string Spiritillusion { get; set; }

        [JsonPropertyName("spiritmanipulation")]
        public string Spiritmanipulation { get; set; }

        [JsonPropertyName("spiritform")]
        public string Spiritform { get; set; }

        [JsonPropertyName("drainattributes")]
        public string Drainattributes { get; set; }

        [JsonPropertyName("drainvalue")]
        public string Drainvalue { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }
    }
}