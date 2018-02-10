using System.Xml.Serialization;


namespace Libraries.enums
{
    public enum AllianceTypesPrefix
    {

        [XmlEnum("eAllianceNone")] None = 0,
        [XmlEnum("eAllianceLegionOfCarthage")] LegionOfCarthage = 1,
        [XmlEnum("eAllianceDelianLeague")] DelianLeague = 2,
        [XmlEnum("eAllianceCouncilOfImhotep")] CouncilOfImhotep = 3,        

    }

}
