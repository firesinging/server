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

        [XmlElement(ElementName = "Name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "CivID")]
        [DefaultValue(Civilizations.Generic)]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "MapName")]
        [DefaultValue(null)]
        public string Mapname { get; set; }

        [XmlElement(ElementName = "MapLocationX")]
        [DefaultValue(null)]
        public string MaplocationX { get; set; }

        [XmlElement(ElementName = "MapLocationY")]
        [DefaultValue(null)]
        public string MaplocationY { get; set; }

        [XmlElement(ElementName = "MapMarker")]
        [DefaultValue(null)]
        public string Mapmarker { get; set; }

        [XmlElement(ElementName = "MapPage")]
        [DefaultValue(null)]
        public string Mappage { get; set; }
        
        [XmlElement(ElementName = "LoadScreen")]
        [DefaultValue(null)]
        public string LoadScreen { get; set; }

        [XmlElement(ElementName = "DescriptionStringID")]
        public int DescriptionstringId { get; set; }

        [XmlElement(ElementName = "DisplayNameStringID")]
        public int DisplaynamestringId { get; set; }

        [XmlElement(ElementName = "AvatarShield")]
        [DefaultValue(null)]
        public string Avatarshield { get; set; }

        [XmlElement(ElementName = "FlagIcon")]
        [DefaultValue(null)]
        public string Flagicon { get; set; }

        [XmlAttribute(AttributeName = "ID")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "hidden")]
        [DefaultValue(null)]
        public string Hidden { get; set; }       

        [XmlElement(ElementName = "PlayList")]
        [DefaultValue(null)]
        public string Playlist { get; set; }        

        [XmlElement(ElementName = "Alliance")]
        [DefaultValue(null)]
        public string Alliance { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
