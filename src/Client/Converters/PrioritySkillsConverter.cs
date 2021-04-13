// TODO: finish this conversion

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Client.Converters
{
    public class PrioritySkillsConverter : JsonConverter<PrioritySkills>
    {
        public override PrioritySkills? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // if (reader.TokenType == JsonTokenType.StartArray)
            // {
            //     return 
            // }

            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, PrioritySkills value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}