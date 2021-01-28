using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Gear
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public string Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("category_english")]
        public string CategoryEnglish { get; set; }

        [JsonPropertyName("iscommlink")]
        public string Iscommlink { get; set; }

        [JsonPropertyName("ispersona")]
        public string Ispersona { get; set; }

        [JsonPropertyName("isammo")]
        public string Isammo { get; set; }

        [JsonPropertyName("isprogram")]
        public string Isprogram { get; set; }

        [JsonPropertyName("isos")]
        public string Isos { get; set; }

        [JsonPropertyName("issin")]
        public string Issin { get; set; }

        [JsonPropertyName("capacity")]
        public string Capacity { get; set; }

        [JsonPropertyName("armorcapacity")]
        public string Armorcapacity { get; set; }

        [JsonPropertyName("maxrating")]
        public object Maxrating { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("matrixcmfilled")]
        public string Matrixcmfilled { get; set; }

        [JsonPropertyName("conditionmonitor")]
        public string Conditionmonitor { get; set; }

        [JsonPropertyName("qty")]
        public string Qty { get; set; }

        [JsonPropertyName("avail")]
        public string Avail { get; set; }

        [JsonPropertyName("avail_english")]
        public string AvailEnglish { get; set; }

        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        [JsonPropertyName("owncost")]
        public string Owncost { get; set; }

        [JsonPropertyName("extra")]
        public object Extra { get; set; }

        [JsonPropertyName("bonded")]
        public string Bonded { get; set; }

        [JsonPropertyName("equipped")]
        public string Equipped { get; set; }

        [JsonPropertyName("wirelesson")]
        public string Wirelesson { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("gearname")]
        public object Gearname { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("children")]
        public object Children { get; set; }

        [JsonPropertyName("weaponbonusdamage")]
        public string Weaponbonusdamage { get; set; }

        [JsonPropertyName("weaponbonusdamage_english")]
        public string WeaponbonusdamageEnglish { get; set; }

        [JsonPropertyName("weaponbonusap")]
        public string Weaponbonusap { get; set; }

        [JsonPropertyName("flechetteweaponbonusdamage")]
        public string Flechetteweaponbonusdamage { get; set; }

        [JsonPropertyName("flechetteweaponbonusdamage_english")]
        public string FlechetteweaponbonusdamageEnglish { get; set; }

        [JsonPropertyName("flechetteweaponbonusap")]
        public string Flechetteweaponbonusap { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("attack")]
        public string Attack { get; set; }

        [JsonPropertyName("sleaze")]
        public string Sleaze { get; set; }

        [JsonPropertyName("dataprocessing")]
        public string Dataprocessing { get; set; }

        [JsonPropertyName("firewall")]
        public string Firewall { get; set; }

        [JsonPropertyName("devicerating")]
        public string Devicerating { get; set; }

        [JsonPropertyName("programlimit")]
        public string Programlimit { get; set; }

        [JsonPropertyName("active")]
        public string Active { get; set; }

        [JsonPropertyName("homenode")]
        public string Homenode { get; set; }
    }
}