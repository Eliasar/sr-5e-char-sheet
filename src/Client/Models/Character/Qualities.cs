using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Qualities   
    {
        [JsonPropertyName("quality")]
        public List<Quality> Quality { get; set; }
    }
}