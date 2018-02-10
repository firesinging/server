using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum Alliances
    {

        [XmlEnum("None")] None = 0,
        [XmlEnum("LegionOfCarthage")] LegionOfCarthage = 1,
        [XmlEnum("DelianLeague")] DelianLeague = 2,
        [XmlEnum("CouncilOfImhotep")] CouncilOfImhotep = 3,        

    }

}
