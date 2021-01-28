using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Limitmodifiersphys
    {
        [JsonPropertyName("limitmodifier")]
        public Limitmodifier Limitmodifier { get; set; }
    }
}