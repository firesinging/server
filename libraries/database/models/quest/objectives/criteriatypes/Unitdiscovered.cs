using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Unitdiscovered model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unitdiscovered")]
    public class ModelQuestObjectivesUnitdiscovered
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

    }

}
