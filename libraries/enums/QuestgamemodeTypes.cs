using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum QuestgamemodeTypes
    {

        [XmlEnum("Normal")] Normal = 0,
        [XmlEnum("AllianceMode")] AllianceMode = 1,
        [XmlEnum("InvasionMode")] InvasionMode = 2,
        [XmlEnum("SkirmishMode")] SkirmishMode = 3        

    }

}
