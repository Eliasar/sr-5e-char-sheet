using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Powers
    {
        [JsonPropertyName("power")]
        public List<Power> Power { get; set; } = new List<Power>();
    }
}