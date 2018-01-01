using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory containers inventory item model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "InventoryItem")]
    public class ModelCharacterInventorycontainerInventoryItem
    {

        [XmlAttribute(AttributeName = "type")]
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

        [XmlAttribute(AttributeName = "isbound")]
        public string Isbound { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

        [XmlAttribute(AttributeName = "seed")]
        public int Seed { get; set; }

        [XmlAttribute(AttributeName = "serializationData")]
        public string SerializationData { get; set; }

    }

}
