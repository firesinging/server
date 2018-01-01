using System.Xml.Serialization;

namespace Libraries.enums
{

    public enum OfferTypesPrefix
    {

        [XmlEnum("cOfferNone")] cOfferNone = 0,
        [XmlEnum("cOfferCivGreek")] cOfferCivGreek = 1,
        [XmlEnum("cOfferCivEgyptian")] cOfferCivEgyptian = 2,
        [XmlEnum("cOfferCivNorse")] cOfferCivNorse = 7,
        [XmlEnum("cOfferCivBabylonian")] cOfferCivBabylonian = 6,
        [XmlEnum("cOfferCivRoman")] cOfferCivRoman = 5,
        [XmlEnum("cOfferCivPersian")] cOfferCivPersian = 4,
        [XmlEnum("cOfferCivCeltic")] cOfferCivCeltic = 3,       

    }

}
