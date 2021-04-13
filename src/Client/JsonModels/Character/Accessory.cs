using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Accessory
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; } 

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("mount")]
        public string Mount { get; set; } 

        [JsonPropertyName("extramount")]
        public string Extramount { get; set; } 

        [JsonPropertyName("rc")]
        public string Rc { get; set; } 

        [JsonPropertyName("conceal")]
        public string Conceal { get; set; } 

        [JsonPropertyName("avail")]
        public string Avail { get; set; } 

        [JsonPropertyName("ratinglabel")]
        public string Ratinglabel { get; set; } 

        [JsonPropertyName("cost")]
        public string Cost { get; set; } 

        [JsonPropertyName("owncost")]
        public string Owncost { get; set; } 

        [JsonPropertyName("included")]
        public string Included { get; set; } 

        [JsonPropertyName("source")]
        public string Source { get; set; } 

        [JsonPropertyName("page")]
        public string Page { get; set; } 

        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; } 

        [JsonPropertyName("gears")]
        public Gears? Gears { get; set; } 

        [JsonPropertyName("notes")]
        public object Notes { get; set; } 
    }
}