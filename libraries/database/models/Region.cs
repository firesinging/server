using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models
{
    /// <summary>
    /// Region model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>
    
    [XmlRoot(ElementName = "Region")]
    public class ModelRegion
    {

        [XmlAttribute(AttributeName = "ID")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "hidden")]
        [DefaultValue(null)]
        public string IsHidden { get; set; }

        [XmlElement(ElementName = "Name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "PlayList")]
        [DefaultValue(null)]
        public string PlayList { get; set; }

        [XmlElement(ElementName = "CivID")]
        [DefaultValue(null)]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "MapName")]
        [DefaultValue(null)]
        public string MapName { get; set; }

        [XmlElement(ElementName = "MapLocationX")]
        [DefaultValue(null)]
        public string MapLocationX { get; set; }

        [XmlElement(ElementName = "MapLocationY")]
        [DefaultValue(null)]
        public string MapLocationY { get; set; }

        [XmlElement(ElementName = "MapMarker")]
        [DefaultValue(null)]
        public string MapMarker { get; set; }

        [XmlElement(ElementName = "MapPage")]
        [DefaultValue(null)]
        public string MapPage { get; set; }

        [XmlElement(ElementName = "LoadScreen")]
        [DefaultValue(null)]
        public string LoadScreen { get; set; }

        [XmlElement(ElementName = "AvatarShield")]
        [DefaultValue(null)]
        public string AvatarShield { get; set; }

        [XmlElement(ElementName = "DescriptionStringID")]
        [DefaultValue(null)]
        public string DescriptionStringId { get; set; }

        [XmlElement(ElementName = "DisplayNameStringID")]
        [DefaultValue(null)]
        public string DisplayNameStringId { get; set; }

        [XmlElement(ElementName = "FlagIcon")]
        [DefaultValue(null)]
        public string FlagIcon { get; set; }

        [XmlElement(ElementName = "Alliance")]
        [DefaultValue(null)]
        public string IsAlliance { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
