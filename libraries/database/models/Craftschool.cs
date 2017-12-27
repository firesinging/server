using System.Xml.Serialization;


namespace Libraries.database.models
{
    /// <summary>
    /// Craftschool model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "school")]
    public class ModelCraftschool
    {

        [XmlElement(ElementName = "tag")]
        public string Tag { get; set; }

        [XmlElement(ElementName = "displayname")]
        public string Displayname { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "startingblueprint")]
        public string Startingblueprint { get; set; }

        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }

        [XmlElement(ElementName = "gearicons")]
        public ModelCraftschoolGearicons Gearicons { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelCraftschoolItems Items { get; set; }

        [XmlElement(ElementName = "design")]
        public string Design { get; set; }

        [XmlElement(ElementName = "craftingsound")]
        public string Craftingsound { get; set; }

        [XmlElement(ElementName = "allowedcapitals")]
        public ModelCraftschoolAllowedcapitals Allowedcapitals { get; set; }

    }

}
