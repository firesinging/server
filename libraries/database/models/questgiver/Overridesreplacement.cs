using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Overrides replacement model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "overrides")]
    public class ModelQuestgiverOverridesReplacement
    {

        [XmlElement(ElementName = "AnimFile")]
        [DefaultValue(null)]
        public string AnimFile { get; set; }

        [XmlElement(ElementName = "DisplayNameID")]
        [DefaultValue(null)]
        public string DisplayNameId { get; set; }

        [XmlElement(ElementName = "ShortRolloverTextID")]
        [DefaultValue(null)]
        public string ShortRolloverTextId { get; set; }                  

        [XmlElement(ElementName = "PortraitIcon")]
        [DefaultValue(null)]
        public string PortraitIcon { get; set; }

        [XmlElement(ElementName = "Icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "VisualScale")]
        [DefaultValue(null)]
        public string VisualScale { get; set; }

    }

}
