using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.inventory
{

    /// <summary>
    /// Inventory inventory items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelInventoryInventoryItems
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryInventoryItems()
        {

            Items = new Dictionary<int, ModelInventoryInventoryItem>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelInventoryInventoryItem> Items { get; private set; }

        [XmlElement(ElementName = "InventoryItem")]
        public ModelInventoryInventoryItem[] ModelInventorycontainerInventoryItem
        {

            get
            {

                List<ModelInventoryInventoryItem> List = new List<ModelInventoryInventoryItem>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<int, ModelInventoryInventoryItem>();

                if (value != null)
                {

                    foreach (ModelInventoryInventoryItem Item in value)
                    {

                        Items.Add(Item.Index, Item);

                    }

                }

            }

        }
        
    }

}
