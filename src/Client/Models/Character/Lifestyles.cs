using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Lifestyles
    {
        [JsonPropertyName("lifestyle")]
        public Lifestyle Lifestyle { get; set; }
    }
}