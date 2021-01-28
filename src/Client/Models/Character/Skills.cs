using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Skills
    {
        [JsonPropertyName("skill")]
        public List<Skill> Skill { get; set; }

        [JsonPropertyName("skillgroup")]
        public Skillgroup Skillgroup { get; set; }
    }
}