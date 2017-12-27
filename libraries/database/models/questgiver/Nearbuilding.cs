using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Nearbuilding model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "nearbuilding")]
    public class ModelQuestgiverNearbuilding
    {

        [XmlElement(ElementName = "nearunittype")]
        public string Nearunittype { get; set; }

        [XmlElement(ElementName = "preferredoffset")]
        public string Preferredoffset { get; set; }

        [XmlElement(ElementName = "radius")]
        public string Radius { get; set; }

        [XmlElement(ElementName = "useboneposition")]
        public string Useboneposition { get; set; }

    }

}
