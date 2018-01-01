using System.Xml.Serialization;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Questcomplete model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questcomplete")]
    public class ModelQuestPrereqsQuestcomplete
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

    }

}
