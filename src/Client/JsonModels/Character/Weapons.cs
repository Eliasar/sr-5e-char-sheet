using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Weapons   
    {
        [JsonPropertyName("weapon")]
        [JsonConverter(typeof(GenericConverter<Weapon>))]
        public List<Weapon> Weapon { get; set; } = new List<Weapon>();
    }
}