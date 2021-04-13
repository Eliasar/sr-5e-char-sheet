using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Lifestyles
    {
        [JsonPropertyName("lifestyle")]
        public Lifestyle Lifestyle { get; set; }
    }
}