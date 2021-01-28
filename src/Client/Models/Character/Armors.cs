using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Armors
    {
        [JsonPropertyName("armor")]
        public List<Armor> Armor { get; set; }
    }
}