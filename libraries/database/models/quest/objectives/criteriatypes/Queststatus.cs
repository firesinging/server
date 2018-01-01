using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Queststatus model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "queststatus")]
    public class ModelQuestObjectivesQueststatus
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "queststatus")]
        public string Queststatus { get; set; }

    }

}
