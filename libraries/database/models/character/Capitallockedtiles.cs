using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital locked tiles model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitallockedtiles")]
    public class ModelCharacterCapitallockedtiles
    {

        [XmlElement(ElementName = "radius")]
        [DefaultValue(null)]
        public string Radius { get; set; }

        [XmlElement(ElementName = "centerpoint")]
        [DefaultValue(null)]
        public string Centerpoint { get; set; }

    }

}
