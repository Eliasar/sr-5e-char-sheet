using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Children
    {
        [JsonPropertyName("gear")]
        public object Gear { get; set; }
    }
}