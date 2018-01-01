using System.Xml.Serialization;

using Libraries.database.models.quest.objectives;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Objectives model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "objectives")]
    public class ModelQuestObjectives
    {

        [XmlElement(ElementName = "values")]
        public ModelQuestObjectivesValues Values { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        public string Mustfailall { get; set; }

    }

}
