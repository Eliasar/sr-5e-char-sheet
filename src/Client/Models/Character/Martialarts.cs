using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Martialarts
    {
        [JsonPropertyName("martialart")]
        public Martialart Martialart { get; set; }
    }
}