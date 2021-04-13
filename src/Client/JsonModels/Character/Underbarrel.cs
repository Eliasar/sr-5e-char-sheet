using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Underbarrel
    {
        [JsonPropertyName("weapon")]
        public Weapon Weapon { get; set; }
    }
}