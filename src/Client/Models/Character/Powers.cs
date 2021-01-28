using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Powers
    {
        [JsonPropertyName("power")]
        public List<Power> Power { get; set; }
    }
}