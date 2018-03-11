using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Level ageupeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ageupeffect")]
    public class ModelLevelAgeupeffect
    {

        [XmlElement(ElementName = "enableage")]
        public int Enableage { get; set; }

    }

}
