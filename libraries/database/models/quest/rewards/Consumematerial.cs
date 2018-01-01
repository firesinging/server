using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Consumematerial model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumematerial")]
    public class ModelQuestRewardsConsumematerial
    {

        [XmlElement(ElementName = "materialname")]
        public string Materialname { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }


    }

}
