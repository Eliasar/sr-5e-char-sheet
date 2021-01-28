using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Skill
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("suid")]
        public string Suid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("skillgroup")]
        public string Skillgroup { get; set; }

        [JsonPropertyName("skillgroup_english")]
        public string SkillgroupEnglish { get; set; }

        [JsonPropertyName("skillcategory")]
        public string Skillcategory { get; set; }

        [JsonPropertyName("skillcategory_english")]
        public string SkillcategoryEnglish { get; set; }

        [JsonPropertyName("grouped")]
        public string Grouped { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }

        [JsonPropertyName("requiresgroundmovement")]
        public string Requiresgroundmovement { get; set; }

        [JsonPropertyName("requiresswimmovement")]
        public string Requiresswimmovement { get; set; }

        [JsonPropertyName("requiresflymovement")]
        public string Requiresflymovement { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("ratingmax")]
        public string Ratingmax { get; set; }

        [JsonPropertyName("specializedrating")]
        public string Specializedrating { get; set; }

        [JsonPropertyName("total")]
        public string Total { get; set; }

        [JsonPropertyName("knowledge")]
        public string Knowledge { get; set; }

        [JsonPropertyName("exotic")]
        public string Exotic { get; set; }

        [JsonPropertyName("buywithkarma")]
        public string Buywithkarma { get; set; }

        [JsonPropertyName("base")]
        public string Base { get; set; }

        [JsonPropertyName("karma")]
        public string Karma { get; set; }

        [JsonPropertyName("spec")]
        public string Spec { get; set; }

        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }

        [JsonPropertyName("displayattribute")]
        public string Displayattribute { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("attributemod")]
        public string Attributemod { get; set; }

        [JsonPropertyName("ratingmod")]
        public string Ratingmod { get; set; }

        [JsonPropertyName("poolmod")]
        public string Poolmod { get; set; }

        [JsonPropertyName("islanguage")]
        public string Islanguage { get; set; }

        [JsonPropertyName("isnativelanguage")]
        public string Isnativelanguage { get; set; }

        [JsonPropertyName("bp")]
        public string Bp { get; set; }

        [JsonPropertyName("skillspecializations")]
        public Skillspecializations Skillspecializations { get; set; }
    }
}