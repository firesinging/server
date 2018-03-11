using System;

using Libraries.enums;
using Libraries.database;
using Libraries.database.models;
using Libraries.database.models.vendor;
using Libraries.database.models.inventory;


namespace Libraries.vendor
{

    public class Vendor : ModelVendor
    {

        public Vendor()
        {    
            
        }

        public ModelInventoryInventoryItem ConvertVendorToInventoryItem(ModelVendorItem ObjVendorItem, int ListPosition = 0)
        {

            ModelInventoryInventoryItem ObjInventoryItem = new ModelInventoryInventoryItem();

            if (ObjVendorItem.Purchase.Trait != null)
            {

                ObjInventoryItem = Database.Traits[ObjVendorItem.Purchase.Trait.Text].ToInventoryItem(ObjVendorItem.Purchase.Trait.Text, ListPosition, ObjVendorItem.Purchase.Trait.Level, ListPosition);

            }
            else if (ObjVendorItem.Purchase.Consumable != null)
            {

                ObjInventoryItem = Database.Consumables[ObjVendorItem.Purchase.Consumable.Text].ToInventoryItem(ObjVendorItem.Purchase.Consumable.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Consumable.Quantity);

            }
            else if (ObjVendorItem.Purchase.Material != null)
            {

                ObjInventoryItem = Database.Materials[ObjVendorItem.Purchase.Material.Text].ToInventoryItem(ObjVendorItem.Purchase.Material.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Material.Quantity);

            }
            else if (ObjVendorItem.Purchase.Blueprint != null)
            {

                ObjInventoryItem = Database.Blueprints[ObjVendorItem.Purchase.Blueprint.Text].ToInventoryItem(ObjVendorItem.Purchase.Blueprint.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Blueprint.Quantity);

            }
            else if (ObjVendorItem.Purchase.Design != null)
            {

                ObjInventoryItem = Database.Designs[ObjVendorItem.Purchase.Design.Text].ToInventoryItem(ObjVendorItem.Purchase.Design.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Design.Quantity);

            }
            else if (ObjVendorItem.Purchase.Advisor != null)
            {

                ObjInventoryItem = Database.Advisors[ObjVendorItem.Purchase.Advisor.Text].ToInventoryItem(ObjVendorItem.Purchase.Advisor.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Advisor.Quantity);

            }
            else if (ObjVendorItem.Purchase.Lootroll != null)
            {

                ObjInventoryItem = Database.Lootrolls[ObjVendorItem.Purchase.Lootroll.Text].ToInventoryItem(ObjVendorItem.Purchase.Lootroll.Text, ListPosition, 0, ListPosition, ObjVendorItem.Purchase.Lootroll.Quantity);

            }
            else
            {

                throw new ArgumentOutOfRangeException($"Vendor::GetInventoryXml - Unknown vendor item");

            }

            ObjInventoryItem.Cost = new ModelInventoryInventoryItemCost() { Capitalresource = new ModelGenericCapitalresource() { Type = CapitalResourceTypes.cCapResCoin, Quantity = 200 } };
            
            return ObjInventoryItem;

        }

        /// <summary>
        /// Get vendor inventory XML.
        /// </summary>
        /// <param name="container">The inventory name.</param>
        /// <returns>The vendor inventory XML.</returns>
        public string ToXml(string container)
        {

            if (Itemsets.Itemset.Items.Items.Count > 0)
            {

                ModelInventoryInventory ObjInventory = new ModelInventoryInventory() { Container = container };

                int ListPosition = 1;

                foreach (ModelVendorItem ObjVendorItem in Itemsets.Itemset.Items.Items)
                {

                    ModelInventoryInventoryItem ObjInventoryItem = ConvertVendorToInventoryItem(ObjVendorItem, ListPosition);

                    ListPosition = ListPosition + 1;

                    ObjInventory.Items.Items.Add(ListPosition, ObjInventoryItem);

                }

                return ObjInventory.ToXml;

            }           

            return "<inventory />";           

        }

    }

}
