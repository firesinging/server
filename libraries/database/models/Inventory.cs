using System.Xml.Serialization;

using Libraries.database.models.inventory;


namespace Libraries.database.models
{

    /// <summary>
    /// Inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainer")]
    public class ModelInventory
    {

        public ModelInventory()
        {

            Info = new ModelInventoryInfo();
            Inventory = new ModelInventoryInventory();

        }

        [XmlElement(ElementName = "info")]
        public ModelInventoryInfo Info { get; set; }

        [XmlElement(ElementName = "inventory")]
        public ModelInventoryInventory Inventory { get; set; }

    }

}
