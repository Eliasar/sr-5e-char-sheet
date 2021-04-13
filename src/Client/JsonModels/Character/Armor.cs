using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Armor
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("category_english")]
        public string CategoryEnglish { get; set; }

        [JsonPropertyName("armor")]
        public string armor { get; set; }

        [JsonPropertyName("avail")]
        public string Avail { get; set; }

        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        [JsonPropertyName("owncost")]
        public string Owncost { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("armorname")]
        public object Armorname { get; set; }

        [JsonPropertyName("equipped")]
        public string Equipped { get; set; }

        [JsonPropertyName("ratinglabel")]
        public string Ratinglabel { get; set; }

        [JsonPropertyName("wirelesson")]
        public string Wirelesson { get; set; }

        [JsonPropertyName("armormods")]
        public object Armormods { get; set; }

        [JsonPropertyName("gears")]
        public Gears? Gears { get; set; }

        [JsonPropertyName("extra")]
        public object Extra { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }
}