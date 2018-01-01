using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Mail message model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    public class ModelEmpireMailmessage
    {

        [XmlAttribute(AttributeName = "xuid")]
        public long Xuid { get; set; }

        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "message")]
        public ModelEmpireMailmessageText MessageText { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelEmpireMailmessageItems Items { get; set; }

        [XmlAttribute(AttributeName = "messageid")]
        public long Messageid { get; set; }        

        [XmlAttribute(AttributeName = "gamertag")]
        public string Gamertag { get; set; }

        [XmlAttribute(AttributeName = "datetime")]
        public long Datetime { get; set; }

        [XmlAttribute(AttributeName = "expirationtime")]
        public long Expirationtime { get; set; }

        [XmlAttribute(AttributeName = "read")]
        public string Read { get; set; }        

        [XmlAttribute(AttributeName = "codmail")]
        public string Codmail { get; set; }

        [XmlAttribute(AttributeName = "issystemmessage")]
        public string IsSystemmessage { get; set; }

        [XmlAttribute(AttributeName = "coin")]
        public int Coin { get; set; }

    }

}
