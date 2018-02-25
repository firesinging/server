using System.Xml.Serialization;


namespace Libraries.database.models.inventory.item.traits
{

    /// <summary>
    /// Inventory item visualfactor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "visualfactor")]
    public class ModelInventoryItemTraitVisualfactor
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "factor")]
        public string Factor { get; set; }

    }

}
