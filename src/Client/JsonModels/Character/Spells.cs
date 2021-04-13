using System.Collections.Generic;
using Newtonsoft.Json;

public class Spells
{
    [JsonProperty("spell")]
    public List<Spell> Spell { get; set; } = new List<Spell>();
}