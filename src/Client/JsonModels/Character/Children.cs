using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Children
    {
        [JsonPropertyName("gear")]
        public object Gear { get; set; }
    }
}