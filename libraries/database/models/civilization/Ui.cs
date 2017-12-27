using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Ui model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ui")]
    public class ModelCivilizationUi
    {

        [XmlElement(ElementName = "civcardinfo")]
        public ModelCivilizationCivcardinfo Civcardinfo { get; set; }

        [XmlElement(ElementName = "civcardorderindex")]
        public string Civcardorderindex { get; set; }

        [XmlElement(ElementName = "craftschooldialoglayout")]
        public string Craftschooldialoglayout { get; set; }

        [XmlElement(ElementName = "equipmentdialogtextures")]
        public ModelCivilizationEquipmentdialogtextures Equipmentdialogtextures { get; set; }

        [XmlElement(ElementName = "gearbuilding")]
        public string Gearbuilding { get; set; }

        [XmlElement(ElementName = "homecityflagtexture")]
        public string Homecityflagtexture { get; set; }

        [XmlElement(ElementName = "homecityflagbuttonset")]
        public string Homecityflagbuttonset { get; set; }

        [XmlElement(ElementName = "homecityflagbuttonsetlarge")]
        public string Homecityflagbuttonsetlarge { get; set; }

        [XmlElement(ElementName = "homecityloadscreens")]
        public ModelCivilizationHomecityloadscreens Homecityloadscreens { get; set; }

        [XmlElement(ElementName = "levelupuianimprefix")]
        public string Levelupuianimprefix { get; set; }

        [XmlElement(ElementName = "mappage")]
        public string Mappage { get; set; }

        [XmlElement(ElementName = "matchmakingtextures")]
        public ModelCivilizationMatchmakingtextures Matchmakingtextures { get; set; }

        [XmlElement(ElementName = "postgameflagtexture")]
        public string Postgameflagtexture { get; set; }

        [XmlElement(ElementName = "shieldtexture")]
        public string Shieldtexture { get; set; }

        [XmlElement(ElementName = "shieldgreytexture")]
        public string Shieldgreytexture { get; set; }

        [XmlElement(ElementName = "storehousetechid")]
        public string Storehousetechid { get; set; }

        [XmlElement(ElementName = "traiteditordialoglayout")]
        public string Traiteditordialoglayout { get; set; }

        [XmlElement(ElementName = "traiteditortraitsperrow")]
        public string Traiteditortraitsperrow { get; set; }

        [XmlElement(ElementName = "welcomedialogs")]
        public ModelCivilizationWelcomedialogs Welcomedialogs { get; set; }

    }

}
