using System;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Effect
    {
        public enum EffectType
        {
            ATTRIBUTE,
            SKILL,
            WEAPON_ACCURACY,
            WEAPON_DAMAGE,
            WOUND_PHYSICAL,
            WOUND_STUN
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string TypeString { get; set; }

        private EffectType type;
        [JsonIgnore]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EffectType Type
        {
            get
            {
                if (type == default(EffectType))
                    type = Enum.Parse<EffectType>(TypeString);
                    
                return type;
            }

            set => type = value;
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

        private int rating;
        [JsonIgnore]
        public int Rating
        {
            get
            {
                if (rating == 0)
                    rating = Convert.ToInt32(RatingString);
                
                return rating;
            }

            set => rating = value;
        }

        [JsonPropertyName("is_active")]
        public string IsActiveString { get; set; }

        private bool isActive;
        [JsonIgnore]
        public bool IsActive
        {
            get
            {
                if (!isActive)
                    Convert.ToBoolean(IsActiveString);

                return isActive;
            }

            set => isActive = value;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Rating: {Rating}, IsActive: {IsActive}";
        }

        public object ToObject()
        {
            string valueToAffect = ValueToAffect;

            if (string.IsNullOrWhiteSpace(valueToAffect))
            {
                valueToAffect = Type.ToString();
            }

            return new
            {
                name = Name,
                affected = valueToAffect,
                rating = Rating
            };
        }
    }
}