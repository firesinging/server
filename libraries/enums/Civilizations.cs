using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum Civilizations
    {

        [XmlEnum("0")] Generic = 0,
        [XmlEnum("1")] Greek = 1,
        [XmlEnum("3")] Egypt = 3,
        [XmlEnum("6")] Celt = 6,
        [XmlEnum("8")] Persia = 8,
        [XmlEnum("22")] Babylonian = 22,
        [XmlEnum("24")] Norse = 24,

    }

}
