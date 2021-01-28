using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Cyberwares
    {
        [JsonPropertyName("cyberwares")]
        public List<Cyberware> Cyberware { get; set; } = new List<Cyberware>();
    }
}