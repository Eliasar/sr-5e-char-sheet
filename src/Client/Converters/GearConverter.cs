using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonModels.Character;

namespace Converters
{
    public class GearConverter : JsonConverter<List<Gear>>
    {
        public override List<Gear>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = new List<Gear>();
            var valueConverter = (JsonConverter<Gear>)options.GetConverter(typeof(Gear));

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject ||
                    reader.TokenType == JsonTokenType.EndArray)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    list.Add(valueConverter.Read(ref reader, typeof(Gear), options));
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<Gear> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}