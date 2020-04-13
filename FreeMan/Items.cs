﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var item = Item.FromJson(jsonString);

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
    using System.Data;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;
    using System.Linq;

    [Serializable]
    public partial class Item
    {
        [J("ID")] public long Id { get; set; }
        [J("Name")] public string Name { get; set; }
        [J("Icon")] public string Icon { get; set; }
        [J("Description")] public string Description { get; set; }
        [J("ItemType")] public ItemType ItemType { get; set; }
        [J("MerchantType")] public MerchantType MerchantType { get; set; }
        [J("Cost")] public long Cost { get; set; }
        [J("CostMul")] public long CostMul { get; set; }
        [J("SlotType")] public SlotType SlotType { get; set; }
        [J("UseEffect")] public long UseEffect { get; set; }
        [J("CanNPCUse")] public bool CanNpcUse { get; set; }
        [J("CanNPCGive")] public bool CanNpcGive { get; set; }
        [J("LevelLimit")] public long LevelLimit { get; set; }
    }

    public enum ItemType { Ammo, Attachment, Clothes, Food, Gift, Gun, Item };

    public enum MerchantType { Clothing, Designweapon, Gift, Prop, Special, Weapon };

    public enum SlotType { Armor, Helmet, Mask, Misc, None, Pa, Pants, Pistol, Pistolsilencer, Rifle, Riflescope, Riflesilencer, Shirt };


    public partial class Item
    {
        public static Dictionary<string, Item> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Item>>(json, QuickType.ItemsConverter.Settings);
    }

    public static class ItemsSerialize
    {
        public static string ToJson(this Dictionary<string, Item> self) => JsonConvert.SerializeObject(self, QuickType.ItemsConverter.Settings);


    }

    public static class CustomLINQtoDataSetMethods
    {
        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source)
        {
            return new ObjectShredder<T>().Shred(source, null, null);
        }

        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source,
                                                    DataTable table, LoadOption? options)
        {
            return new ObjectShredder<T>().Shred(source, table, options);
        }

        public static T DeepCopy<T>(this T obj)

        {

            if (!typeof(T).IsSerializable)

            {

                throw new Exception("The source object must be serializable");

            }

            if (Object.ReferenceEquals(obj, null))

            {

                throw new Exception("The source object must not be null");

            }

            T result = default(T);

            using (var memoryStream = new MemoryStream())

            {

                var formatter = new BinaryFormatter();

                formatter.Serialize(memoryStream, obj);

                memoryStream.Seek(0, SeekOrigin.Begin);

                result = (T)formatter.Deserialize(memoryStream);

                memoryStream.Close();

            }

            return result;

        }

        public static void HideImageMargins(this ToolStrip menuStrip)
        {
            HideImageMargins(menuStrip.Items.OfType<ToolStripMenuItem>().ToList());
        }

        private static void HideImageMargins( this List<ToolStripMenuItem> toolStripMenuItems)
        {
            toolStripMenuItems.ForEach(item =>
            {
                if (!(item.DropDown is ToolStripDropDownMenu dropdown))
                {
                    return;
                }

                dropdown.ShowImageMargin = false;

                HideImageMargins(item.DropDownItems.OfType<ToolStripMenuItem>().ToList());
            });
        }
    }

    internal static class ItemsConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ItemTypeConverter.Singleton,
                MerchantTypeConverter.Singleton,
                SlotTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemType) || t == typeof(ItemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AMMO":
                    return ItemType.Ammo;
                case "ATTACHMENT":
                    return ItemType.Attachment;
                case "CLOTHES":
                    return ItemType.Clothes;
                case "FOOD":
                    return ItemType.Food;
                case "GIFT":
                    return ItemType.Gift;
                case "GUN":
                    return ItemType.Gun;
                case "ITEM":
                    return ItemType.Item;
            }
            throw new Exception("Cannot unmarshal type ItemType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemType)untypedValue;
            switch (value)
            {
                case ItemType.Ammo:
                    serializer.Serialize(writer, "AMMO");
                    return;
                case ItemType.Attachment:
                    serializer.Serialize(writer, "ATTACHMENT");
                    return;
                case ItemType.Clothes:
                    serializer.Serialize(writer, "CLOTHES");
                    return;
                case ItemType.Food:
                    serializer.Serialize(writer, "FOOD");
                    return;
                case ItemType.Gift:
                    serializer.Serialize(writer, "GIFT");
                    return;
                case ItemType.Gun:
                    serializer.Serialize(writer, "GUN");
                    return;
                case ItemType.Item:
                    serializer.Serialize(writer, "ITEM");
                    return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }

    internal class MerchantTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MerchantType) || t == typeof(MerchantType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DESIGNWEAPON":
                    return MerchantType.Designweapon;
                case "CLOTHING":
                    return MerchantType.Clothing;
                case "GIFT":
                    return MerchantType.Gift;
                case "PROP":
                    return MerchantType.Prop;
                case "SPECIAL":
                    return MerchantType.Special;
                case "WEAPON":
                    return MerchantType.Weapon;
            }
            throw new Exception("Cannot unmarshal type MerchantType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MerchantType)untypedValue;
            switch (value)
            {
                case MerchantType.Designweapon:
                    serializer.Serialize(writer, "DESIGNWEAPON");
                    return;
                case MerchantType.Clothing:
                    serializer.Serialize(writer, "CLOTHING");
                    return;
                case MerchantType.Gift:
                    serializer.Serialize(writer, "GIFT");
                    return;
                case MerchantType.Prop:
                    serializer.Serialize(writer, "PROP");
                    return;
                case MerchantType.Special:
                    serializer.Serialize(writer, "SPECIAL");
                    return;
                case MerchantType.Weapon:
                    serializer.Serialize(writer, "WEAPON");
                    return;
            }
            throw new Exception("Cannot marshal type MerchantType");
        }

        public static readonly MerchantTypeConverter Singleton = new MerchantTypeConverter();
    }

    internal class SlotTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SlotType) || t == typeof(SlotType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ARMOR":
                    return SlotType.Armor;
                case "HELMET":
                    return SlotType.Helmet;
                case "MASK":
                    return SlotType.Mask;
                case "MISC":
                    return SlotType.Misc;
                case "NONE":
                    return SlotType.None;
                case "PA":
                    return SlotType.Pa;
                case "PANTS":
                    return SlotType.Pants;
                case "PISTOL":
                    return SlotType.Pistol;
                case "PISTOLSILENCER":
                    return SlotType.Pistolsilencer;
                case "RIFLE":
                    return SlotType.Rifle;
                case "RIFLESCOPE":
                    return SlotType.Riflescope;
                case "RIFLESILENCER":
                    return SlotType.Riflesilencer;
                case "SHIRT":
                    return SlotType.Shirt;
            }
            throw new Exception("Cannot unmarshal type SlotType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SlotType)untypedValue;
            switch (value)
            {
                case SlotType.Armor:
                    serializer.Serialize(writer, "ARMOR");
                    return;
                case SlotType.Helmet:
                    serializer.Serialize(writer, "HELMET");
                    return;
                case SlotType.Mask:
                    serializer.Serialize(writer, "MASK");
                    return;
                case SlotType.Misc:
                    serializer.Serialize(writer, "MISC");
                    return;
                case SlotType.None:
                    serializer.Serialize(writer, "NONE");
                    return;
                case SlotType.Pa:
                    serializer.Serialize(writer, "PA");
                    return;
                case SlotType.Pants:
                    serializer.Serialize(writer, "PANTS");
                    return;
                case SlotType.Pistol:
                    serializer.Serialize(writer, "PISTOL");
                    return;
                case SlotType.Pistolsilencer:
                    serializer.Serialize(writer, "PISTOLSILENCER");
                    return;
                case SlotType.Rifle:
                    serializer.Serialize(writer, "RIFLE");
                    return;
                case SlotType.Riflescope:
                    serializer.Serialize(writer, "RIFLESCOPE");
                    return;
                case SlotType.Riflesilencer:
                    serializer.Serialize(writer, "RIFLESILENCER");
                    return;
                case SlotType.Shirt:
                    serializer.Serialize(writer, "SHIRT");
                    return;
            }
            throw new Exception("Cannot marshal type SlotType");
        }

        public static readonly SlotTypeConverter Singleton = new SlotTypeConverter();
    }
}
