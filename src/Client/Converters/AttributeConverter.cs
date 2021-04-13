using System;
using System.Collections.Generic;
using System.Text.Json;
using JsonModels.Character;

namespace Converters
{
    public class AttributeConverter : GenericConverter<Attributes>
    {
        public override List<Attributes>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            RemoveSingleStringElements = true;

            return base.Read(ref reader, typeToConvert, options);
        }
    }
}