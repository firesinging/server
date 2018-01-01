using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Reduceunitsto model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "reduceunitsto")]
    public class ModelQuestObjectivesReduceunitsto
    {

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "includeteam")]
        public string Includeteam { get; set; }

        [XmlElement(ElementName = "includeunderconstruction")]
        public string Includeunderconstruction { get; set; }

        [XmlElement(ElementName = "canuncomplete")]
        public string Canuncomplete { get; set; }

        [XmlElement(ElementName = "causesfailure")]
        public string Causesfailure { get; set; }

        [XmlElement(ElementName = "playerid")]
        public int Playerid { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

    }

}
