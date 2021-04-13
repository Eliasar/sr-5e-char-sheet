using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Skills
    {
        [JsonPropertyName("skill")]
        public List<Skill> Skill { get; set; }

        [JsonPropertyName("skillgroup")]
        [JsonConverter(typeof(GenericConverter<Skillgroup>))]
        public List<Skillgroup> Skillgroup { get; set; }
    }
}