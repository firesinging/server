using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Unitregen model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unitregen")]
    public class ModelCivilizationUnitregen
    {

        [XmlElement(ElementName = "unittype")]
        public string Unittype { get; set; }

        [XmlElement(ElementName = "rate")]
        public string Rate { get; set; }

        [XmlElement(ElementName = "idletimeout")]
        public string Idletimeout { get; set; }

    }

}
