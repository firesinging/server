using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Character level ageupeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ageupeffect")]
    public class ModelCharacterlevelAgeupeffect
    {

        [XmlElement(ElementName = "enableage")]
        public int Enableage { get; set; }

    }

}
