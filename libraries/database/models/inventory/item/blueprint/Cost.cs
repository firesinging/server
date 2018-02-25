using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.inventory.item.blueprint
{

    /// <summary>
    /// Inventory item blueprint cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelInventoryItemBlueprintCost
    {

        public ModelInventoryItemBlueprintCost()
        {

            Items = new List<ModelGenericMaterial>();

        }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelGenericMaterial> Items { get; set; }

    }

}
