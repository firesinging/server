using System.Xml.Serialization;


namespace Libraries.database.models.objectives
{

    /// <summary>
    /// Techstatus model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "techstatus")]
    public class ModelQuestObjectivesTechstatus
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

    }

}
