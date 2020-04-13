﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var designChart = DesignChart.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using R = Newtonsoft.Json.Required;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class DesignChart
    {
        [J("ID")] public long Id { get; set; }
        [J("Des")] public string Des { get; set; }
        [J("WeaponID")] public long WeaponId { get; set; }
        [J("WeaponName")] public string WeaponName { get; set; }
        [J("AddPrice")] public long AddPrice { get; set; }
        [J("DesignType1")] public DesignType DesignType1 { get; set; }
        [J("AddValue1")] public decimal AddValue1 { get; set; }
        [J("DesignType2")] public DesignType DesignType2 { get; set; }
        [J("AddValue2")] public decimal AddValue2 { get; set; }
    }

    public enum DesignType { Accuracy, Ammotype, Bulletspeed, Damage, Empty, Firerate, Magsize, Shotnum };

    public partial class DesignChart
    {
        public static Dictionary<string, DesignChart> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, DesignChart>>(json, QuickType.DesignChartConverter.Settings);
    }

    public static class DesignChartSerialize
    {
        public static string ToJson(this Dictionary<string, DesignChart> self) => JsonConvert.SerializeObject(self, QuickType.DesignChartConverter.Settings);
    }

    internal static class DesignChartConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DesignTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DesignTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DesignType) || t == typeof(DesignType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return DesignType.Empty;
                case "ACCURACY":
                    return DesignType.Accuracy;
                case "AMMOTYPE":
                    return DesignType.Ammotype;
                case "BULLETSPEED":
                    return DesignType.Bulletspeed;
                case "DAMAGE":
                    return DesignType.Damage;
                case "FIRERATE":
                    return DesignType.Firerate;
                case "MAGSIZE":
                    return DesignType.Magsize;
                case "SHOTNUM":
                    return DesignType.Shotnum;
            }
            throw new Exception("Cannot unmarshal type DesignType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DesignType)untypedValue;
            switch (value)
            {
                case DesignType.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case DesignType.Accuracy:
                    serializer.Serialize(writer, "ACCURACY");
                    return;
                case DesignType.Ammotype:
                    serializer.Serialize(writer, "AMMOTYPE");
                    return;
                case DesignType.Bulletspeed:
                    serializer.Serialize(writer, "BULLETSPEED");
                    return;
                case DesignType.Damage:
                    serializer.Serialize(writer, "DAMAGE");
                    return;
                case DesignType.Firerate:
                    serializer.Serialize(writer, "FIRERATE");
                    return;
                case DesignType.Magsize:
                    serializer.Serialize(writer, "MAGSIZE");
                    return;
                case DesignType.Shotnum:
                    serializer.Serialize(writer, "SHOTNUM");
                    return;
            }
            throw new Exception("Cannot marshal type DesignType");
        }

        public static readonly DesignTypeConverter Singleton = new DesignTypeConverter();
    }
}