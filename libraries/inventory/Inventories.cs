using System.Collections.Generic;
using System.Linq;

using Libraries.database.models;


namespace Libraries.inventory
{

    /// <summary>
    /// Inventories library.
    /// </summary>
    public class Inventories : ModelInventories
    {

        public Inventories()
        {

        }

        /// <summary>
        /// Total inventories.
        /// </summary>
        public int TotalInventories => Items.Count;

        /// <summary>
        /// Total capacity of inventories.
        /// </summary>
        public int TotalCapacity => Items.Values.Sum(i => i.Info.Maxcapacity);

        /// <summary>
        /// Total items in all inventories.
        /// </summary>
        public int TotalItems => Items.Values.Sum(i => i.Inventory.Items.Items.Count);

        /// <summary>
        /// Add inventory to inventory dictionary.
        /// </summary>
        /// <param name="objInventory">The inventory object to add.</param>
        public void Add(Inventory objInventory)
        {

            Items.Add(objInventory.Info.Id, objInventory);
            
        }

        /// <summary>
        /// Get inventory from inventory dictionary by name.
        /// </summary>
        /// <param name="name">The inventory name.</param>
        /// <returns>The inventory object.</returns>
        public Inventory Get(string name)
        {

            Items.TryGetValue(name, out Inventory ObjInventory);

            return ObjInventory;

        }

        /// <summary>
        /// Find inventory by item id.
        /// </summary>
        /// <param name="index">The item index.</param>
        /// <returns>The inventory object.</returns>
        public Inventory FindInventoryForItem(int index)
        {

            Inventory ObjInventory = Items.Values.FirstOrDefault(key => key.Inventory.Items.Items.ContainsKey(index));

            return ObjInventory;

        }


    }

}