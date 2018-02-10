using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.equipment;


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
        public CivilizationsShort Civ { get; set; }

        [XmlElement(ElementName = "maxrank")]
        public int Maxrank { get; set; }

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
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
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "uipanel")]
        public int Uipanel { get; set; }

        [XmlElement(ElementName = "uirow")]
        public int Uirow { get; set; }

        [XmlElement(ElementName = "uicol")]
        public int Uicol { get; set; }

        [XmlElement(ElementName = "agerequirement")]
        public int Agerequirement { get; set; }

        [XmlElement(ElementName = "grantedatlevel")]
        public string Grantedatlevel { get; set; }

        [XmlElement(ElementName = "grantinglevel")]
        public int Grantinglevel { get; set; }

        [XmlElement(ElementName = "ranks")]
        public ModelEquipmentRanks Ranks { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "prereq")]
        public int Prereq { get; set; }
        
    }

}
