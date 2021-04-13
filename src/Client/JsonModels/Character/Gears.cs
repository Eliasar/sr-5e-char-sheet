using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Gears
    {
        [JsonPropertyName("gear")]
        [JsonConverter(typeof(GenericConverter<Gear>))]
        public List<Gear> Gear { get; set; }
    }
}