using System.Text.Json.Serialization;
using JsonModels.Character;

public class Mod
{
    [JsonPropertyName("guid")]
    public string Guid { get; set; } 

    [JsonPropertyName("sourceid")]
    public string Sourceid { get; set; } 

    [JsonPropertyName("name")]
    public string Name { get; set; } 

    [JsonPropertyName("fullname")]
    public string Fullname { get; set; } 

    [JsonPropertyName("category")]
    public string Category { get; set; } 

    [JsonPropertyName("limit")]
    public object Limit { get; set; } 

    [JsonPropertyName("slots")]
    public string Slots { get; set; } 

    [JsonPropertyName("rating")]
    public string Rating { get; set; } 

    [JsonPropertyName("ratinglabel")]
    public string Ratinglabel { get; set; } 

    [JsonPropertyName("avail")]
    public string Avail { get; set; } 

    [JsonPropertyName("cost")]
    public string Cost { get; set; } 

    [JsonPropertyName("owncost")]
    public string Owncost { get; set; } 

    [JsonPropertyName("source")]
    public string Source { get; set; } 

    [JsonPropertyName("wirelesson")]
    public string Wirelesson { get; set; } 

    [JsonPropertyName("page")]
    public string Page { get; set; } 

    [JsonPropertyName("included")]
    public string Included { get; set; } 

    [JsonPropertyName("weapons")]
    public Weapons? Weapons { get; set; } 

    [JsonPropertyName("cyberwares")]
    public Cyberwares? Cyberwares { get; set; } 

    [JsonPropertyName("notes")]
    public object Notes { get; set; } 
}