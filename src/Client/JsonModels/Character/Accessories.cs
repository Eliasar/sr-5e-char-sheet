using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Accessories   
    {
        [JsonPropertyName("accessory")]
        [JsonConverter(typeof(GenericConverter<Accessory>))]
        public List<Accessory> Accessory { get; set; } = new List<Accessory>();
    }
}