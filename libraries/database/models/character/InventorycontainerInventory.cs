using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory container inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainer")]
    public class ModelCharacterInventorycontainerInventory : ModelBase
    {

        public ModelCharacterInventorycontainerInventory()
        {

            Items = new ModelCharacterInventorycontainerInventoryItems();

        }

        [XmlElement(ElementName = "container")]
        public string Container { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelCharacterInventorycontainerInventoryItems Items { get; set; }

    }

}
