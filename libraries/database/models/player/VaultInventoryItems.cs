using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Vault inventory items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVaultInventory")]
    public class ModelPlayerVaultInventoryItems
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelPlayerVaultInventoryItems()
        {

            Items = new Dictionary<int, ModelPlayerVaultInventoryItem>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelPlayerVaultInventoryItem> Items { get; private set; }

        [XmlElement(ElementName = "InventoryItem")]
        public ModelPlayerVaultInventoryItem[] ModelPlayerVaultInventoryItem
        {

            get
            {

                List<ModelPlayerVaultInventoryItem> List = new List<ModelPlayerVaultInventoryItem>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<int, ModelPlayerVaultInventoryItem>();

                if (value != null)
                {

                    foreach (ModelPlayerVaultInventoryItem Item in value)
                    {

                        Items.Add(Item.Index, Item);

                    }

                }

            }

        }

    }

}
