using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum CivilizationsShort
    {

        [XmlEnum("Any")] Generic = 0,
        [XmlEnum("Greek")] Greek = 1,
        [XmlEnum("Egyptian")] Egypt = 3,
        [XmlEnum("Celtic")] Celt = 6,
        [XmlEnum("Persian")] Persia = 8,
        [XmlEnum("Babylonian")] Babylonian = 22,
        [XmlEnum("Norse")] Norse = 24,

    }

}
