using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum CivilizationsPrefix
    {

        [XmlEnum("eCivMatchingTypeAny")] Generic = 0,
        [XmlEnum("eCivMatchingTypeGreek")] Greek = 1,
        [XmlEnum("eCivMatchingTypeEgyptian")] Egypt = 3,
        [XmlEnum("eCivMatchingTypeCeltic")] Celt = 6,
        [XmlEnum("eCivMatchingTypePersian")] Persia = 8,
        [XmlEnum("eCivMatchingTypeBabylonian")] Babylonian = 22,
        [XmlEnum("eCivMatchingTypeNorse")] Norse = 24,

    }

}
