using System.Xml.Serialization;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Purchase model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "purchase")]
    public class ModelVendorPurchase
    {

        [XmlElement(ElementName = "trait")]
        public ModelGenericTrait Trait { get; set; }

        [XmlElement(ElementName = "consumable")]
        public ModelVendorConsumable Consumable { get; set; }

        [XmlElement(ElementName = "material")]
        public ModelVendorMaterial Material { get; set; }

        [XmlElement(ElementName = "blueprint")]
        public ModelGenericBlueprint Blueprint { get; set; }

        [XmlElement(ElementName = "design")]
        public ModelGenericDesign Design { get; set; }

        [XmlElement(ElementName = "advisor")]
        public ModelGenericAdvisor Advisor { get; set; }

        [XmlElement(ElementName = "lootroll")]
        public ModelGenericLootRoll Lootroll { get; set; }

        [XmlElement(ElementName = "quest")]
        public ModelGenericQuest Quest { get; set; }

    }

}
