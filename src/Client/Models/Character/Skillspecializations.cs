using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Skillspecializations
    {
        [JsonPropertyName("skillspecialization")]
        public Skillspecialization Skillspecialization { get; set; }
    }
}