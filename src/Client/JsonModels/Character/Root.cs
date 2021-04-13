using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Root
    {
        [JsonPropertyName("?xml")]
        public Xml Xml { get; set; }

        [JsonPropertyName("characters")]
        public Characters Characters { get; set; }
    }
}