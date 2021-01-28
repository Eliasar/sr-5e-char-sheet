using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Martialarttechniques
    {
        [JsonPropertyName("martialarttechnique")]
        public List<Martialarttechnique> Martialarttechnique { get; set; }
    }
}