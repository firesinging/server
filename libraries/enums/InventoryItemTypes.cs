using System.Xml.Serialization;


namespace Libraries.enums
{

    public enum InventoryItemTypes
    {

        [XmlEnum("Generic")] Generic = 0,
        [XmlEnum("Advisor")] Advisor = 1,
        [XmlEnum("Blueprint")] Blueprint = 2,
        [XmlEnum("Consumable")] Consumable = 3,
        [XmlEnum("Design")] Design = 4,
        [XmlEnum("Lootroll")] Lootroll = 5,
        [XmlEnum("Material")] Material = 6,
        [XmlEnum("Trait")] Trait = 7,

    }

}
