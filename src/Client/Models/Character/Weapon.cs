using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Weapon   
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

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("reach")]
        public string Reach { get; set; }

        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        [JsonPropertyName("damage")]
        public string Damage { get; set; }

        [JsonPropertyName("damage_english")]
        public string DamageEnglish { get; set; }

        [JsonPropertyName("rawdamage")]
        public string Rawdamage { get; set; }

        [JsonPropertyName("ap")]
        public string Ap { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("rc")]
        public string Rc { get; set; }

        [JsonPropertyName("ammo")]
        public string Ammo { get; set; }

        [JsonPropertyName("ammo_english")]
        public string AmmoEnglish { get; set; }

        [JsonPropertyName("conceal")]
        public string Conceal { get; set; }

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

        [JsonPropertyName("weaponname")]
        public object Weaponname { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("ranges")]
        public Ranges Ranges { get; set; }

        [JsonPropertyName("alternateranges")]
        public Alternateranges Alternateranges { get; set; }

        [JsonPropertyName("availableammo")]
        public string Availableammo { get; set; }

        [JsonPropertyName("currentammo")]
        public object Currentammo { get; set; }

        [JsonPropertyName("clips")]
        public object Clips { get; set; }

        [JsonPropertyName("dicepool")]
        public string Dicepool { get; set; }

        [JsonPropertyName("skill")]
        public string Skill { get; set; }

        [JsonPropertyName("wirelesson")]
        public string Wirelesson { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("accessories")]
        public Accessories Accessories { get; set; }
    }
}