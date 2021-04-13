using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Skillspecializations
    {
        [JsonPropertyName("skillspecialization")]
        [JsonConverter(typeof(GenericConverter<Skillspecialization>))]
        public List<Skillspecialization> Skillspecialization { get; set; }
    }
}