using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Lifestyle
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("sourceid")]
        public List<string> Sourceid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        [JsonPropertyName("totalmonthlycost")]
        public string Totalmonthlycost { get; set; }

        [JsonPropertyName("totalcost")]
        public string Totalcost { get; set; }

        [JsonPropertyName("dice")]
        public string Dice { get; set; }

        [JsonPropertyName("multiplier")]
        public string Multiplier { get; set; }

        [JsonPropertyName("months")]
        public string Months { get; set; }

        [JsonPropertyName("purchased")]
        public string Purchased { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("increment")]
        public string Increment { get; set; }

        [JsonPropertyName("bonuslp")]
        public string Bonuslp { get; set; }

        [JsonPropertyName("baselifestyle")]
        public string Baselifestyle { get; set; }

        [JsonPropertyName("trustfund")]
        public string Trustfund { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("qualities")]
        public object Qualities { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }
}