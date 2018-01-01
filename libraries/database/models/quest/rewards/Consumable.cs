using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Consumable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumable")]
    public class ModelQuestRewardsConsumable
    {

        [XmlElement(ElementName = "consumablename")]
        public string Consumablename { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
