using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Qualities   
    {
        [JsonPropertyName("quality")]
        public List<Quality> Quality { get; set; }
    }
}