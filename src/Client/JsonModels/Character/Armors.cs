using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Armors
    {
        [JsonPropertyName("armor")]
        [JsonConverter(typeof(GenericConverter<Armor>))]
        public List<Armor> Armor { get; set; } = new List<Armor>();
    }
}