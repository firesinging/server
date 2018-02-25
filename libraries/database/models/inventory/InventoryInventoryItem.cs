using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models.inventory
{

    /// <summary>
    /// Inventory inventory item model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "InventoryItem")]
    public class ModelInventoryInventoryItem
    {

        public ModelInventoryInventoryItem()
        {

            Cost = new ModelInventoryInventoryItemCost();

        }

        [XmlAttribute(AttributeName = "type")]
        public InventoryItemTypes Type { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "itempos")]
        public int Itempos { get; set; }

        [XmlAttribute(AttributeName = "count")]
        [DefaultValue(0)]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "index")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "sellable")]
        public string Sellable { get; set; }

        [XmlAttribute(AttributeName = "tradeable")]
        public string Tradeable { get; set; }

        [XmlAttribute(AttributeName = "destroyable")]
        public string Destroyable { get; set; }

        [XmlAttribute(AttributeName = "isbound")]
        public string Isbound { get; set; }

        [XmlAttribute(AttributeName = "level")]
        [DefaultValue(0)]
        public int Level { get; set; }

        [XmlAttribute(AttributeName = "seed")]
        [DefaultValue(0)]
        public int Seed { get; set; }

        [XmlElement(ElementName = "cost")]
        [DefaultValue(null)]
        public ModelInventoryInventoryItemCost Cost { get; set; }

        [XmlAttribute(AttributeName = "serializationData")]
        public string SerializationData { get; set; }

    }

}
