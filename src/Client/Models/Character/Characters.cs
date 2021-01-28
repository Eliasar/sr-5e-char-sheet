using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Characters
    {
        [JsonPropertyName("character")]
        public Character Character { get; set; }
    }
}