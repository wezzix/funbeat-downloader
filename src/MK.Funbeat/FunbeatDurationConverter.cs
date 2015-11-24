using System;
using Newtonsoft.Json;

namespace MK.Funbeat
{
    public class FunbeatDurationConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(
            JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var funbeatDuration = serializer.Deserialize(reader, typeof(FunbeatDuration)) as FunbeatDuration;
                return funbeatDuration.TimeSpan;
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}