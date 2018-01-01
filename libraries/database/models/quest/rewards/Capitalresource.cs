using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Capitalresource model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "aiflagvariables")]
    public class ModelQuestRewardsCapitalresource
    {

        [XmlElement(ElementName = "capitalresource")]
        public string Capitalresource { get; set; }

        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
