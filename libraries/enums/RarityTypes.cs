using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum RarityTypes
    {

        [XmlEnum("junk")] Junk = 0,
        [XmlEnum("common")] Common = 1,
        [XmlEnum("uncommon")] Uncommon = 2,
        [XmlEnum("rare")] Rare = 3,
        [XmlEnum("epic")] Epic = 4,
        [XmlEnum("legendary")] Legendary = 5,

    }

}
