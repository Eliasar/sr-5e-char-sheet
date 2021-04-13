using System.Collections.Generic;
using System.Text.Json.Serialization;
using Converters;

namespace JsonModels.Character
{
    public class Vehicles
    {
        [JsonPropertyName("vehicle")]
        [JsonConverter(typeof(GenericConverter<Vehicle>))]
        public List<Vehicle> Vehicle { get; set; } = new List<Vehicle>();
    }
}