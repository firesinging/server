using System.Xml.Serialization;


namespace Libraries.database.models.inventory
{

    /// <summary>
    /// Inventory inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainer")]
    public class ModelInventoryInventory : ModelBase
    {

        public ModelInventoryInventory()
        {

            Items = new ModelInventoryInventoryItems();

        }

        [XmlElement(ElementName = "container")]
        public string Container { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelInventoryInventoryItems Items { get; set; }

    }

}
