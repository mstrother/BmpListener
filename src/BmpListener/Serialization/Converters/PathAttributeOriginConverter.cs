﻿using System;
using BmpListener.Bgp;
using Newtonsoft.Json;

namespace BmpListener.Serialization.Converters
{
    public class PathAttributeOriginConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(PathAttributeOrigin);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var origin = (PathAttributeOrigin)value;

            switch (origin.Origin)
            {
                case PathAttributeOrigin.Type.Igp:
                    writer.WriteValue("igp");
                    break;
                case PathAttributeOrigin.Type.Egp:
                    writer.WriteValue("egp");
                    break;
                case PathAttributeOrigin.Type.Incomplete:
                    writer.WriteValue("incomplete");
                    break;
                default:
                    writer.WriteValue("incomplete");
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
