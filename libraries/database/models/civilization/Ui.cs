using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization ui model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ui")]
    public class ModelCivilizationUi
    {

        [XmlElement(ElementName = "civcardinfo")]
        public ModelCivilizationCivcardinfo Civcardinfo { get; set; }

        [XmlElement(ElementName = "civcardorderindex")]
        public int Civcardorderindex { get; set; }

        [XmlElement(ElementName = "craftschooldialoglayout")]
        [DefaultValue(null)]
        public string Craftschooldialoglayout { get; set; }

        [XmlElement(ElementName = "equipmentdialogtextures")]
        public ModelCivilizationEquipmentdialogtextures Equipmentdialogtextures { get; set; }

        [XmlElement(ElementName = "gearbuilding")]
        public int Gearbuilding { get; set; }

        [XmlElement(ElementName = "homecityflagtexture")]
        [DefaultValue(null)]
        public string Homecityflagtexture { get; set; }

        [XmlElement(ElementName = "homecityflagbuttonset")]
        [DefaultValue(null)]
        public string Homecityflagbuttonset { get; set; }

        [XmlElement(ElementName = "homecityflagbuttonsetlarge")]
        [DefaultValue(null)]
        public string Homecityflagbuttonsetlarge { get; set; }

        [XmlElement(ElementName = "homecityloadscreens")]
        public ModelCivilizationHomecityloadscreens Homecityloadscreens { get; set; }

        [XmlElement(ElementName = "levelupuianimprefix")]
        [DefaultValue(null)]
        public string Levelupuianimprefix { get; set; }

        [XmlElement(ElementName = "mappage")]
        [DefaultValue(null)]
        public string Mappage { get; set; }

        [XmlElement(ElementName = "matchmakingtextures")]
        public ModelCivilizationMatchmakingtextures Matchmakingtextures { get; set; }

        [XmlElement(ElementName = "postgameflagtexture")]
        [DefaultValue(null)]
        public string Postgameflagtexture { get; set; }

        [XmlElement(ElementName = "shieldtexture")]
        [DefaultValue(null)]
        public string Shieldtexture { get; set; }

        [XmlElement(ElementName = "shieldgreytexture")]
        [DefaultValue(null)]
        public string Shieldgreytexture { get; set; }

        [XmlElement(ElementName = "storehousetechid")]
        public int Storehousetechid { get; set; }

        [XmlElement(ElementName = "traiteditordialoglayout")]
        [DefaultValue(null)]
        public string Traiteditordialoglayout { get; set; }

        [XmlElement(ElementName = "traiteditortraitsperrow")]
        public int Traiteditortraitsperrow { get; set; }

        [XmlElement(ElementName = "welcomedialogs")]
        public ModelCivilizationWelcomedialogs Welcomedialogs { get; set; }

    }

}
