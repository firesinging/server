using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail message model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    public class ModelPlayerMailmessage
    {

        public ModelPlayerMailmessage()
        {

            MessageText = new ModelPlayerMailmessageText();
            Items = new ModelPlayerMailmessageItems();

        }

        [XmlAttribute(AttributeName = "xuid")]
        public long Xuid { get; set; }

        [XmlElement(ElementName = "subject")]
        [DefaultValue(null)]
        public string Subject { get; set; }

        [XmlElement(ElementName = "message")]
        [DefaultValue(null)]
        public ModelPlayerMailmessageText MessageText { get; set; }

        [XmlElement(ElementName = "items")]
        [DefaultValue(null)]
        public ModelPlayerMailmessageItems Items { get; set; }

        [XmlAttribute(AttributeName = "messageid")]
        public long Messageid { get; set; }        

        [XmlAttribute(AttributeName = "gamertag")]
        [DefaultValue(null)]
        public string Gamertag { get; set; }

        [XmlAttribute(AttributeName = "datetime")]
        public long Datetime { get; set; }

        [XmlAttribute(AttributeName = "expirationtime")]
        public long Expirationtime { get; set; }

        [XmlAttribute(AttributeName = "read")]
        [DefaultValue(null)]
        public string Read { get; set; }        

        [XmlAttribute(AttributeName = "codmail")]
        [DefaultValue(null)]
        public string Codmail { get; set; }

        [XmlAttribute(AttributeName = "issystemmessage")]
        [DefaultValue(null)]
        public string IsSystemmessage { get; set; }

        [XmlAttribute(AttributeName = "coin")]
        public int Coin { get; set; }

    }

}
