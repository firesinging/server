using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum PlayerTypes
    {

        [XmlEnum("None")] None = 0,
        [XmlEnum("Human")] Human = 1,
        [XmlEnum("Computer")] Computer = 2,       

    }

}
