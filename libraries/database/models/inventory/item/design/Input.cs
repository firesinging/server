using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.inventory.item.design
{

    /// <summary>
    /// Inventory item design input model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "input")]
    public class ModelInventoryItemDesignInput
    {

        public ModelInventoryItemDesignInput()
        {

            Items = new List<ModelGenericMaterial>();

        }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelGenericMaterial> Items { get; set; }

    }

}
