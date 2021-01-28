using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Root
    {
        [JsonPropertyName("?xml")]
        public Xml Xml { get; set; }

        [JsonPropertyName("characters")]
        public Characters Characters { get; set; }
    }
}