using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.inventory.item.design
{

    /// <summary>
    /// nventory item design output consumable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumable")]
    public class ModelInventoryItemDesignOutputConsumable
    {

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
