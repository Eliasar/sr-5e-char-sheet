using System;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Effect
    {
        public enum EffectType
        {
            ATTRIBUTE
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string TypeString { get; set; }

        [JsonIgnore]
        public EffectType Type
        {
            get => Enum.Parse<EffectType>(TypeString);
        }

        [JsonPropertyName("value_to_affect")]
        public string ValueToAffect { get; set; }

        [JsonPropertyName("minimum")]
        public string MinimumString { get; set; }

        [JsonIgnore]
        public int Minimum
        {
            get => Convert.ToInt32(MinimumString);
        }

        [JsonPropertyName("maximum")]
        public string MaximumString { get; set; }

        [JsonIgnore]
        public int Maximum
        {
            get => Convert.ToInt32(MaximumString);
        }

        [JsonPropertyName("rating")]
        public string RatingString { get; set; }

        [JsonIgnore]
        public int Rating
        {
            get => Convert.ToInt32(RatingString);
        }

        [JsonPropertyName("is_active")]
        public string IsActiveString { get; set; }

        [JsonIgnore]
        public bool IsActive
        {
            get => Convert.ToBoolean(IsActiveString);
        }
    }
}