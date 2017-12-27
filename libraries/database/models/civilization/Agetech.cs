using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Age tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "agetech")]
    public class ModelCivilizationAgetech
    {

        [XmlElement(ElementName = "age")]
        public string Age { get; set; }

        [XmlElement(ElementName = "tech")]
        public string Tech { get; set; }

        [XmlElement(ElementName = "tierequipmentid")]
        public string Tierequipmentid { get; set; }

    }

}
