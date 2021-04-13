using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Mods
    {
        [JsonPropertyName("mods")]
        [JsonConverter(typeof(GenericConverter<Mod>))]
        public List<Mod> Mod { get; set; } = new List<Mod>();
    }
}