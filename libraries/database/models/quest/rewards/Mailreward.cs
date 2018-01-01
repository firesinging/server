using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Mailreward model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "mailreward")]
    public class ModelQuestRewardsMailreward
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlAttribute(AttributeName = "subject")]
        public string Subject { get; set; }

        [XmlAttribute(AttributeName = "message")]
        public string Message { get; set; }

        [XmlAttribute(AttributeName = "gold")]
        public int Gold { get; set; }

        [XmlAttribute(AttributeName = "sendtovisittarget")]
        public string Sendtovisittarget { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
