using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Owns unit model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ownsunit")]
    public class ModelQuestObjectivesOwnsunit
    {

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "owningplayerid")]
        public int Owningplayerid { get; set; }

        [XmlElement(ElementName = "causesfailure")]
        public string Causesfailure { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

    }

}
