using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// And model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "and")]
    public class ModelQuestObjectivesAnd
    {

        [XmlElement(ElementName = "values")]
        public ModelQuestObjectivesCriteria Values { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        public string Mustfailall { get; set; }

    }

}
