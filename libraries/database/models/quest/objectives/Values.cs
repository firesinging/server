using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Values model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "values")]
    public class ModelQuestObjectivesValues
    {

        [XmlElement(ElementName = "or")]
        public ModelQuestObjectivesOr Or { get; set; }

    }

}
