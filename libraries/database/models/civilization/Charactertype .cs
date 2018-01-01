using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization character type  model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "charactertype")]
    public class ModelCivilizationCharactertype
    {

        [XmlElement(ElementName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlElement(ElementName = "file")]
        [DefaultValue(null)]
        public string File { get; set; }

    }

}
