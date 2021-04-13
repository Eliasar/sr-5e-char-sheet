using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Contact
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("connection")]
        public string Connection { get; set; }

        [JsonPropertyName("loyalty")]
        public string Loyalty { get; set; }

        [JsonPropertyName("metatype")]
        public string Metatype { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("contacttype")]
        public object Contacttype { get; set; }

        [JsonPropertyName("preferredpayment")]
        public object Preferredpayment { get; set; }

        [JsonPropertyName("hobbiesvice")]
        public object Hobbiesvice { get; set; }

        [JsonPropertyName("personallife")]
        public object Personallife { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("forcedloyalty")]
        public string Forcedloyalty { get; set; }

        [JsonPropertyName("blackmail")]
        public string Blackmail { get; set; }

        [JsonPropertyName("family")]
        public string Family { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    }
}