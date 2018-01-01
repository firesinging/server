using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Gamecurrency model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrency")]
    public class ModelQuestRewardsGamecurrency
    {

        [XmlElement(ElementName = "gamecurrency")]
        public string Gamecurrency { get; set; }

        [XmlElement(ElementName = "amount")]
        public int Amount { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
