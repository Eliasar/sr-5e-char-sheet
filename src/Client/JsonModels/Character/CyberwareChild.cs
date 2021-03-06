using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class CyberwareChild
    {
        [JsonPropertyName("cyberware")]
        [JsonConverter(typeof(GenericConverter<Cyberware>))]
        public List<Cyberware> Cyberware { get; set; }
    }
}