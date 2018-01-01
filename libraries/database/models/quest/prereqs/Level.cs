using System.Xml.Serialization;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Level model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "level")]
    public class ModelQuestPrereqsLevel
    {

        [XmlElement(ElementName = "min")]
        public int Min { get; set; }

        [XmlElement(ElementName = "max")]
        public int Max { get; set; }

    }

}
