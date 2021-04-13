using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Characters
    {
        [JsonPropertyName("character")]
        public Character Character { get; set; }
    }
}