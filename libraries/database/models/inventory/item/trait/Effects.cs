using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.inventory.item.traits
{

    /// <summary>
    /// Inventory item effects model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "effects")]
    public class ModelInventoryItemTraitEffects
    {

        public ModelInventoryItemTraitEffects()
        {

            Items = new List<ModelInventoryItemTraitEffectsEffect>();

        }

        [XmlElement(ElementName = "effect")]
        [DefaultValue(null)]
        public List<ModelInventoryItemTraitEffectsEffect> Items { get; set; }

    }

}
