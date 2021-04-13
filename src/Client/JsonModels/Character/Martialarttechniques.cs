using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Martialarttechniques
    {
        [JsonPropertyName("martialarttechnique")]
        public List<Martialarttechnique> Martialarttechnique { get; set; }
    }
}