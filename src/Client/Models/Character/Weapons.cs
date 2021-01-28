using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Weapons   
    {
        [JsonPropertyName("weapon")]
        public List<Weapon> Weapon { get; set; }
    }
}