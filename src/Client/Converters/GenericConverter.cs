using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Converters
{
    public class GenericConverter<T> : JsonConverter<List<T>>
    {
        public bool RemoveSingleStringElements = false;
        
        public override List<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = new List<T>();
            var valueConverter = (JsonConverter<T>)options.GetConverter(typeof(T));

            if (reader.TokenType == JsonTokenType.StartObject)
            {
                list.Add(valueConverter.Read(ref reader, typeof(T), options));
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read())
                {
                    if (RemoveSingleStringElements && reader.TokenType == JsonTokenType.String)
                    {
                        // Nothing, comment here to skip single string elements
                        continue;
                    }

                    if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        break;
                    }

                    if (reader.TokenType == JsonTokenType.String)
                    {
                        Console.WriteLine($"Element: {reader.GetString()}");
                    }

                    list.Add(valueConverter.Read(ref reader, typeof(T), options));
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}