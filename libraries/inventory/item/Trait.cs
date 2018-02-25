using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.inventory;
using Libraries.database.models.inventory.item;


namespace Libraries.inventory.item
{

    [XmlRoot(ElementName = "trait")]
    public class Trait : ModelInventoryItemTrait
    {

        public Trait()
        {    
            
        }

        /// <summary>
        /// Convert item to inventory item
        /// </summary>
        /// <param name="key">The item key.</param>
        /// <param name="position">The inventory position.</param>
        /// <param name="level">The item level.</param>
        /// <param name="index">The item inventory index.</param>
        /// <param name="count">The number of items.</param>
        /// <param name="seed">The item seed.</param>
        /// <param name="serializationData">The item serialization data.</param>
        /// <param name="sellable">Flag if the item is sellable.</param>
        /// <param name="tradeable">Flag if the item is tradeable.</param>
        /// <param name="destroyable">Flag if the item is destroyable.</param>
        /// <param name="isBound">Flag if the item is bound.</param>
        /// <returns>The inventory item.</returns>
        public ModelInventoryInventoryItem ToInventoryItem(string key, int position, int level, int index, int count = 1, int seed = 0, string serializationData = "addsilent", string sellable = "false", string tradeable = "false", string destroyable = "false", string isBound = "false")
        {

            ModelInventoryInventoryItem Item = new ModelInventoryInventoryItem() { Id = key, Type = InventoryItemTypes.Trait, Itempos = position, Count = count, Index = index, Sellable = sellable, Tradeable = tradeable, Destroyable = destroyable, Isbound = isBound, Level = level, Seed = seed, SerializationData = serializationData };

            return Item;

        }



    }

}
