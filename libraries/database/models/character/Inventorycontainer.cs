using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory container model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainer")]
    public class ModelCharacterInventorycontainer
    {

        public ModelCharacterInventorycontainer()
        {

            Info = new ModelCharacterInventorycontainerInfo();
            Inventory = new ModelCharacterInventorycontainerInventory();

        }

        [XmlElement(ElementName = "info")]
        public ModelCharacterInventorycontainerInfo Info { get; set; }

        [XmlElement(ElementName = "inventory")]
        public ModelCharacterInventorycontainerInventory Inventory { get; set; }

    }

}
