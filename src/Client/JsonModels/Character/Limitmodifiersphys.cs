using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Limitmodifiers
    {
        [JsonPropertyName("limitmodifier")]
        [JsonConverter(typeof(GenericConverter<Limitmodifier>))]
        public List<Limitmodifier> Limitmodifier { get; set; }
    }
}