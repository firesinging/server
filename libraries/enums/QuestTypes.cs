using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum QuestTypes
    {

        [XmlEnum("CapitolCity")] CapitolCity = 0,
        [XmlEnum("RandomMap")] RandomMap = 1,
        [XmlEnum("Global")] Global = 2,
        [XmlEnum("PvP")] PvP = 3

    }

}
