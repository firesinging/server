using System.Xml.Serialization;


namespace Libraries.enums
{
    public enum Alliances
    {

        [XmlEnum("LegionOfCarthage")] LegionOfCarthage = 0,
        [XmlEnum("DelianLeague")] DelianLeague = 1,
        [XmlEnum("CouncilOfImhotep")] CouncilOfImhotep = 2

    }

}
