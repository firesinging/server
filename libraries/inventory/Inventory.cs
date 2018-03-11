using System;
using System.Linq;

using Libraries.database.models;
using Libraries.database.models.inventory;


namespace Libraries.inventory
{

    public class Inventory : ModelInventory
    {

        public Inventory()
        {

        }

        /// <summary>
        /// Set inventory info.
        /// </summary>
        /// <param name="name">The inventory name.</param>
        /// <param name="maxcapacity">The inventory maxcapacity.</param>
        public void SetInfo(string name, int maxcapacity)
        {

            Info.Id = name;
            Info.Maxcapacity = maxcapacity;

        }

        /// <summary>
        /// Set inventory inventory.
        /// </summary>
        /// <param name="name">The inventory name.</param>
        /// <param name="items">The inventory items.</param>
        public void SetInventory(string name, ModelInventoryInventoryItems items = null)
        {

            Inventory.Container = name;
            Inventory.Items = items;

        }

        public ModelInventoryInventoryItem GetItem(int index)
        {

            Inventory.Items.Items.TryGetValue(index, out ModelInventoryInventoryItem ObjInventoryItem);

            return ObjInventoryItem;

        }

        /// <summary>
        /// Remove player from players dictionary.
        /// </summary>
        /// <param name="id">The player Id.</param>
        /// <returns>True when player is removed.</returns>
        public bool RemoveItem(int index)
        {

            return Inventory.Items.Items.Remove(index);

        }




    }

}