using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Population model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "population")]
    public class ModelQuestObjectivesPopulation
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "currentgoal")]
        public int Currentgoal { get; set; }

        [XmlElement(ElementName = "capgoal")]
        public int Capgoal { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }


    }

}
