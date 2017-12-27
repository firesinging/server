using System.Xml.Serialization;


namespace Libraries.database.models.rewards
{

    /// <summary>
    /// Alliancepoints model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "alliancepoints")]
    public class ModelQuestRewardsAlliancepoints
    {

        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
