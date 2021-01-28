using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Attributes
    {
        [JsonPropertyName("attributecategory_english")]
        public string AttributecategoryEnglish { get; set; }

        [JsonPropertyName("attribute")]
        public List<Attribute> Attribute { get; set; }
    }
}