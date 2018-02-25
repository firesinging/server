using System;


using Libraries.inventory;

namespace Libraries.helpers.inventory
{

    public static class InventoryHelper
    {

        /// <summary>
        /// Check if the prototype and unitname is a new warehouse for character
        /// </summary>
        /// <param name="protounit">The protoname</param>
        /// <param name="unitname">The unitname</param>
        /// <param name="i">The current inventories</param>
        /// <returns>True if the combination prototype and unitname represents a new warehouse for character</returns>
        public static bool IsNewWarehouse(string protounit, string unitname, Inventories i)
        {

            if ((!string.IsNullOrEmpty(protounit)) && (!string.IsNullOrEmpty(unitname)) && (MaxcapacityForWarehouse(protounit) > 0))
            {

                if (i.Get(unitname) == null)
                {

                    return true;

                }

            }            

            return false;

        }

        /// <summary>
        /// Get maximum capacity for warehouse
        /// </summary>
        /// <param name="warehouse">The protoname</param>
        /// <returns>Maximum capacity for warehouse</returns>
        public static int MaxcapacityForWarehouse(string warehouse)
        {

            if (String.IsNullOrEmpty(warehouse))
            {

                return 0;

            }

            if (warehouse.ToLower().Contains("warehouse01"))
            {

                return 8;

            } else if (warehouse.ToLower().Contains("warehouse02"))
            {

                return 12;

            } else if (warehouse.ToLower().Contains("warehouse03"))
            {

                return 16;

            } else if (warehouse.ToLower().Contains("warehouse04"))
            {

                return 20;

            } else if (warehouse.ToLower().Contains("warehouse05"))
            {

                return 24;

            }

            return 0;

        }

    }

}
