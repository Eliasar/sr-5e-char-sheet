using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Accessories   
    {
        [JsonPropertyName("accessory")]
        public object Accessory { get; set; }
    }
}