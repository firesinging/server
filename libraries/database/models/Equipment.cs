using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Equipment model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "equipment")]
    public class ModelEquipment
    {

        [XmlElement(ElementName = "civ")]
        public string Civ { get; set; }

        [XmlElement(ElementName = "maxrank")]
        public string Maxrank { get; set; }

        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }

        [XmlElement(ElementName = "largeicon")]
        public string Largeicon { get; set; }

        [XmlElement(ElementName = "bldorunit")]
        public string Bldorunit { get; set; }

        [XmlElement(ElementName = "questreward")]
        public string Questreward { get; set; }

        [XmlElement(ElementName = "suppresseffects")]
        public string Suppresseffects { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "uipanel")]
        public string Uipanel { get; set; }

        [XmlElement(ElementName = "uirow")]
        public string Uirow { get; set; }

        [XmlElement(ElementName = "uicol")]
        public string Uicol { get; set; }

        [XmlElement(ElementName = "agerequirement")]
        public string Agerequirement { get; set; }

        [XmlElement(ElementName = "grantedatlevel")]
        public string Grantedatlevel { get; set; }

        [XmlElement(ElementName = "grantinglevel")]
        public string Grantinglevel { get; set; }

        [XmlElement(ElementName = "ranks")]
        public ModelEquipmentRanks Ranks { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "offertype")]
        public string Offertype { get; set; }

        [XmlElement(ElementName = "prereq")]
        public string Prereq { get; set; }
        
    }

}
