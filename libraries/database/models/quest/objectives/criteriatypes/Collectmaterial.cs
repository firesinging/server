using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Collectmaterial model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "collectmaterial")]
    public class ModelQuestObjectivesCollectmaterial
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "amount")]
        public int Amount { get; set; }

        [XmlElement(ElementName = "includeexisting")]
        public string Includeexisting { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }


    }

}
