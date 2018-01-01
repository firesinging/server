using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Override model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "override")]
    public class ModelQuestgiverOverride
    {

        [XmlElement(ElementName = "key")]
        public string Key { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

    }

}
