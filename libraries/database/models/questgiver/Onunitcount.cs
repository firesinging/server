using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Onunitcount model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "onunitcount")]
    public class ModelQuestgiverOnunitcount
    {

        [XmlElement(ElementName = "countunittype")]
        public string Countunittype { get; set; }

        [XmlElement(ElementName = "comparetype")]
        public string Comparetype { get; set; }

        [XmlElement(ElementName = "count")]
        public string Count { get; set; }

    }

}
