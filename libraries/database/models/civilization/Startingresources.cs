using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization starting resources model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "startingresources")]
    public class ModelCivilizationStartingresources
    {

        [XmlElement(ElementName = "gold")]
        public int Gold { get; set; }

        [XmlElement(ElementName = "food")]
        public int Food { get; set; }

        [XmlElement(ElementName = "wood")]
        public int Wood { get; set; }

        [XmlElement(ElementName = "stone")]
        public int Stone { get; set; }

    }

}
