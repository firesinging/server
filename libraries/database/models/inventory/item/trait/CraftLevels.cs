using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.inventory.item.traits
{

    /// <summary>
    /// Inventory item craft levels model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "craftlevels")]
    public class ModelInventoryItemTraitCraftLevels
    {

        public ModelInventoryItemTraitCraftLevels()
        {

            Items = new List<int>();

        }

        [XmlElement(ElementName = "level")]
        [DefaultValue(null)]
        public List<int> Items { get; set; }
    
    }

}
