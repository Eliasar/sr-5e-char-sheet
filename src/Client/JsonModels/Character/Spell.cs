using Newtonsoft.Json;

public class Spell
{
    [JsonProperty("guid")]
    public string Guid { get; set; }

    [JsonProperty("sourceid")]
    public string Sourceid { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("name_english")]
    public string NameEnglish { get; set; }

    [JsonProperty("descriptors")]
    public string Descriptors { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("category_english")]
    public string CategoryEnglish { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("range")]
    public string Range { get; set; }

    [JsonProperty("damage")]
    public string Damage { get; set; }

    [JsonProperty("duration")]
    public string Duration { get; set; }

    [JsonProperty("dv")]
    public string Dv { get; set; }

    [JsonProperty("alchemy")]
    public string Alchemy { get; set; }

    [JsonProperty("dicepool")]
    public string Dicepool { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("page")]
    public string Page { get; set; }

    [JsonProperty("extra")]
    public object Extra { get; set; }

    [JsonProperty("notes")]
    public object Notes { get; set; }
}