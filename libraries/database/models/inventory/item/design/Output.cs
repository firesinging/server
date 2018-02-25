using System.Xml.Serialization;


namespace Libraries.database.models.inventory.item.design
{

    /// <summary>
    /// nventory item design output model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "output")]
    public class ModelInventoryItemDesignOutput
    {

        [XmlElement(ElementName = "material")]
        public ModelGenericMaterial Material { get; set; }

        [XmlElement(ElementName = "trait")]
        public ModelGenericTrait Trait { get; set; }

        [XmlElement(ElementName = "consumable")]
        public ModelInventoryItemDesignOutputConsumable Consumable { get; set; }

    }

}
