using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Material model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "material")]
    public class ModelQuestRewardsMaterial
    {

        [XmlElement(ElementName = "materialname")]
        public string Materialname { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
