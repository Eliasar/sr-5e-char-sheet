using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Xml
    {
        [JsonPropertyName("@version")]
        public string Version { get; set; }

        [JsonPropertyName("@encoding")]
        public string Encoding { get; set; }
    }
}