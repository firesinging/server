using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Timer model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "timer")]
    public class ModelQuestObjectivesTimer
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "failonexpire")]
        public string Failonexpire { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

    }

}
