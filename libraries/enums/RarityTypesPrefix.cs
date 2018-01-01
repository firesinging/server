using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum RarityTypesPrefix
    {

        [XmlEnum("cRarityJunk")] Junk = 0,
        [XmlEnum("cRarityCommon")] Common = 1,
        [XmlEnum("cRarityUncommon")] Uncommon = 2,
        [XmlEnum("cRarityRare")] Rare = 3,
        [XmlEnum("cRarityEpic")] Epic = 4,
        [XmlEnum("cRarityCommon")] Legendary = 5,

    }

}
