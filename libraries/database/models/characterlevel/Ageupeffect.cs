using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Ageupeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ageupeffect")]
    public class ModelCharacterlevelAgeupeffect
    {

        [XmlElement(ElementName = "enableage")]
        public string Enableage { get; set; }

    }

}
