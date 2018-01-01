using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization civcardinfo model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "civcardinfo")]
    public class ModelCivilizationCivcardinfo
    {

        [XmlElement(ElementName = "civstatus")]
        public string Civstatus { get; set; }

        [XmlElement(ElementName = "civcardtext")]
        public string Civcardtext { get; set; }

        [XmlElement(ElementName = "civcardinfotext")]
        public string Civcardinfotext { get; set; }

        [XmlElement(ElementName = "civcardbackground")]
        public string Civcardbackground { get; set; }

        [XmlElement(ElementName = "civcardbackgroundp")]
        public string Civcardbackgroundp { get; set; }

        [XmlElement(ElementName = "civinfobackground")]
        public string Civinfobackground { get; set; }

        [XmlElement(ElementName = "civinfobackgroundp")]
        public string Civinfobackgroundp { get; set; }

        [XmlElement(ElementName = "civshield")]
        public string Civshield { get; set; }

    }

}
