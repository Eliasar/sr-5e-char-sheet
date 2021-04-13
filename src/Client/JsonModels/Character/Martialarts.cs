using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Martialarts
    {
        [JsonPropertyName("martialart")]
        [JsonConverter(typeof(GenericConverter<Martialart>))]
        public List<Martialart> Martialart { get; set; }
    }
}