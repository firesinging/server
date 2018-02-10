using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Nearbuilding model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "nearbuilding")]
    public class ModelQuestgiverNearbuilding
    {

        [XmlElement(ElementName = "nearunittype")]
        [DefaultValue(null)]
        public string Nearunittype { get; set; }

        [XmlElement(ElementName = "preferredoffset")]
        public string Preferredoffset { get; set; }

        [XmlElement(ElementName = "radius")]
        public int Radius { get; set; }

        [XmlElement(ElementName = "useboneposition")]
        public string Useboneposition { get; set; }

    }

}
