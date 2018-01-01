using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Unitnearunit model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unitnearunit")]
    public class ModelQuestObjectivesUnitnearunit
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "neededunittype")]
        public string Neededunittype { get; set; }

        [XmlElement(ElementName = "nearunittype")]
        public string Nearunittype { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "radius")]
        public int Radius { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

    }

}
