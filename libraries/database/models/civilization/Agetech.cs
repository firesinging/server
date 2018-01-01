using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization age tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "agetech")]
    public class ModelCivilizationAgetech
    {

        [XmlElement(ElementName = "age")]
        [DefaultValue(null)]
        public string Age { get; set; }

        [XmlElement(ElementName = "tech")]
        [DefaultValue(null)]
        public string Tech { get; set; }

        [XmlElement(ElementName = "tierequipmentid")]
        public int Tierequipmentid { get; set; }

    }

}
