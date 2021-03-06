﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var soldier = Soldier.FromJson(jsonString);

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

    public partial class Soldier
    {
        [J("ID")] public long Id { get; set; }
        [J("Name")] public string Name { get; set; }
        [J("Icon")] public string Icon { get; set; }
        [J("Sex")] public Sex Sex { get; set; }
        [J("Type")] public TypeEnum Type { get; set; }
        [J("FireIntervalOverride")] public long FireIntervalOverride { get; set; }
        [J("Cost")] public long Cost { get; set; }
        [J("Health")] public long Health { get; set; }
        [J("Marksmanship")] public long Marksmanship { get; set; }
        [J("SightBonus")] public decimal SightBonus { get; set; }
        [J("Speed")] public decimal Speed { get; set; }
        [J("PistolPoint")] public long PistolPoint { get; set; }
        [J("RiflePoint")] public long RiflePoint { get; set; }
        [J("SmgPoint")] public long SmgPoint { get; set; }
        [J("ShotGunPoint")] public long ShotGunPoint { get; set; }
        [J("AssaultRiflePoint")] public long AssaultRiflePoint { get; set; }
        [J("MachineGunPoint")] public long MachineGunPoint { get; set; }
        [J("LauncherPoint")] public long LauncherPoint { get; set; }
        [J("ThrowingPoint")] public long ThrowingPoint { get; set; }
        [J("ArmorPoint")] public long ArmorPoint { get; set; }
        [J("PercentAdd")] public decimal PercentAdd { get; set; }
        [J("MaxMISCNum")] public long MaxMiscNum { get; set; }
        [J("HelmetId")] public List<long> HelmetId { get; set; }
        [J("ShirtId")] public List<long> ShirtId { get; set; }
        [J("ArmorId")] public List<long> ArmorId { get; set; }
        [J("PantsId")] public List<long> PantsId { get; set; }
        [J("MaskId")] public List<long> MaskId { get; set; }
        [J("PistolId")] public List<long> PistolId { get; set; }
        [J("RifleId")] public List<long> RifleId { get; set; }
        [J("HeadName")] public string HeadName { get; set; }
        [J("FaceTextureName")] public string FaceTextureName { get; set; }
        [J("HairName")] public string HairName { get; set; }
        [J("EyeName")] public EyeName EyeName { get; set; }
        [J("misc1Id")] public long Misc1Id { get; set; }
        [J("misc2Id")] public long Misc2Id { get; set; }
        [J("misc3Id")] public long Misc3Id { get; set; }
        [J("HairColorIndex")] public long HairColorIndex { get; set; }
    }

    public enum TypeEnum { Far, Middle, Near };
    public partial class Soldier
    {
        public static Dictionary<string, Soldier> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Soldier>>(json, QuickType.SoldierConverter.Settings);
    }

    public static class SoldierSerialize
    {
        public static string ToJson(this Dictionary<string, Soldier> self) => JsonConvert.SerializeObject(self, QuickType.SoldierConverter.Settings);
    }

    internal static class SoldierConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                 TypeEnumConverter.Singleton,
                EyeNameConverter.Singleton,
                SexConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FAR":
                    return TypeEnum.Far;
                case "MIDDLE":
                    return TypeEnum.Middle;
                case "NEAR":
                    return TypeEnum.Near;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Far:
                    serializer.Serialize(writer, "FAR");
                    return;
                case TypeEnum.Middle:
                    serializer.Serialize(writer, "MIDDLE");
                    return;
                case TypeEnum.Near:
                    serializer.Serialize(writer, "NEAR");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
