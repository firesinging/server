using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Vault inventory item model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "InventoryItem")]
    public class ModelPlayerVaultInventoryItem
    {

        public ModelPlayerVaultInventoryItem()
        {

            Cost = new ModelPlayerVaultInventoryItemCost();

        }

        [XmlElement(ElementName = "Cost")]
        public ModelPlayerVaultInventoryItemCost Cost { get; set; }

        [XmlAttribute(AttributeName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "itempos")]
        public int Itempos { get; set; }

        [XmlAttribute(AttributeName = "count")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "index")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "sellable")]
        public string Sellable { get; set; }

        [XmlAttribute(AttributeName = "tradeable")]
        public string Tradeable { get; set; }

        [XmlAttribute(AttributeName = "destroyable")]
        public string Destroyable { get; set; }

        [XmlAttribute(AttributeName = "serializationData")]
        [DefaultValue(null)]
        public string SerializationData { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

        [XmlAttribute(AttributeName = "seed")]
        public int Seed { get; set; }

    }

}
