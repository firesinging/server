using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.craftschool;


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
        public int Displayname { get; set; }

        [XmlElement(ElementName = "description")]
        public int Description { get; set; }

        [XmlElement(ElementName = "startingblueprint")]
        [DefaultValue(null)]
        public string Startingblueprint { get; set; }

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "gearicons")]
        public ModelCraftschoolGearicons Gearicons { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelCraftschoolItems Items { get; set; }

        [XmlElement(ElementName = "design")]
        [DefaultValue(null)]
        public string Design { get; set; }

        [XmlElement(ElementName = "craftingsound")]
        [DefaultValue(null)]
        public string Craftingsound { get; set; }

        [XmlElement(ElementName = "allowedcapitals")]
        public ModelCraftschoolAllowedcapitals Allowedcapitals { get; set; }

    }

}
