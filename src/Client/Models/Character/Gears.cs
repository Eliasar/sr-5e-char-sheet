using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Gears
    {
        [JsonPropertyName("gear")]
        public List<Gear> Gear { get; set; }
    }
}