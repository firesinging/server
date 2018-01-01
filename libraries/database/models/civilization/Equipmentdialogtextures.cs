using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization equipment dialog textures model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "equipmentdialogtextures")]
    public class ModelCivilizationEquipmentdialogtextures
    {

        [XmlElement(ElementName = "tab1background")]
        public string Tab1background { get; set; }

        [XmlElement(ElementName = "tab2background")]
        public string Tab2background { get; set; }

        [XmlElement(ElementName = "tab3background")]
        public string Tab3background { get; set; }

        [XmlElement(ElementName = "tab4background")]
        public string Tab4background { get; set; }

        [XmlElement(ElementName = "tab1overlay2")]
        public string Tab1overlay2 { get; set; }

        [XmlElement(ElementName = "tab1overlay3")]
        public string Tab1overlay3 { get; set; }

        [XmlElement(ElementName = "tab1overlay4")]
        public string Tab1overlay4 { get; set; }

        [XmlElement(ElementName = "tab2overlay2")]
        public string Tab2overlay2 { get; set; }

        [XmlElement(ElementName = "tab2overlay3")]
        public string Tab2overlay3 { get; set; }

        [XmlElement(ElementName = "tab2overlay4")]
        public string Tab2overlay4 { get; set; }

        [XmlElement(ElementName = "tab3overlay2")]
        public string Tab3overlay2 { get; set; }

        [XmlElement(ElementName = "tab3overlay3")]
        public string Tab3overlay3 { get; set; }

        [XmlElement(ElementName = "tab3overlay4")]
        public string Tab3overlay4 { get; set; }

        [XmlElement(ElementName = "milestonebanner")]
        public string Milestonebanner { get; set; }

        [XmlElement(ElementName = "milestonebannerdisabled")]
        public string Milestonebannerdisabled { get; set; }

    }

}
