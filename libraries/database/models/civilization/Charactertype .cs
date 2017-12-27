using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Character type  model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "charactertype")]
    public class ModelCivilizationCharactertype
    {

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "file")]
        public string File { get; set; }

    }

}
