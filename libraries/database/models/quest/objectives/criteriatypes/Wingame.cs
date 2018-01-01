using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Wingame model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "dummy")]
    public class ModelQuestObjectivesWingame
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "suppressfail")]
        public string Suppressfail { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }


    }

}
