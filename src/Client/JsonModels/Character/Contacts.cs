using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Contacts
    {
        [JsonPropertyName("contact")]
        public List<Contact> Contact { get; set; }
    }
}