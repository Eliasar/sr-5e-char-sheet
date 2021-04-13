using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Cyberware
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("ess")]
        public string Essence { get; set; }

        [JsonPropertyName("capacity")]
        public string Capacity { get; set; }

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

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("minrating")]
        public string Minrating { get; set; }

        [JsonPropertyName("maxrating")]
        public string Maxrating { get; set; }

        [JsonPropertyName("ratinglabel")]
        public string Ratinglabel { get; set; }

        [JsonPropertyName("allowsubsystems")]
        public object Allowsubsystems { get; set; }

        [JsonPropertyName("wirelesson")]
        public string Wirelesson { get; set; }

        [JsonPropertyName("grade")]
        public string Grade { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("extra")]
        public object Extra { get; set; }

        [JsonPropertyName("improvementsource")]
        public string Improvementsource { get; set; }

        [JsonPropertyName("gears")]
        public Gears? Gears { get; set; }

        [JsonPropertyName("children")]
        public CyberwareChild? Children { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("iscommlink")]
        public string Iscommlink { get; set; }

        [JsonPropertyName("active")]
        public string Active { get; set; }

        [JsonPropertyName("homenode")]
        public string Homenode { get; set; }

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
    }
}