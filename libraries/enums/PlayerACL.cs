using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum PlayerACL
    {

        [XmlEnum("1")] ConnectAuthServer = 1,
        [XmlEnum("2")] ConnectGameServer = 2,
        [XmlEnum("3")] ConnectChatServer = 3,
        [XmlEnum("4")] ConnectManagerServer = 4,   

    }

}
