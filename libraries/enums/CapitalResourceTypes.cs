using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum CapitalResourceTypes
    {

        [XmlEnum("None")] None = 0,
        [XmlEnum("cCapResCoin")] cCapResCoin = 1,
        [XmlEnum("cCapResWorkers")] cCapResWorkers = 2,
        [XmlEnum("cCapResFactionPoints1")] cCapResFactionPoints1 = 3,
        [XmlEnum("cCapResFactionPoints2")] cCapResFactionPoints2 = 4,
        [XmlEnum("cCapResFactionPoints3")] cCapResFactionPoints3 = 5,

    }

}
