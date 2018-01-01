using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Or model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "or")]
    public class ModelQuestObjectivesOr
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "values")]
        public ModelQuestObjectivesCriteria Values { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        public string Mustfailall { get; set; }

    }

}
