using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization allowed character types model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "wall")]
    public class ModelCivilizationAllowedcharactertypes
    {

        [XmlElement(ElementName = "charactertype")]
        public ModelCivilizationCharactertype Charactertype { get; set; }

    }

}
