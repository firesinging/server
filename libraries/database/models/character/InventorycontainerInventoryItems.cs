using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory containers inventory items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelCharacterInventorycontainerInventoryItems
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterInventorycontainerInventoryItems()
        {

            Items = new Dictionary<int, ModelCharacterInventorycontainerInventoryItem>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelCharacterInventorycontainerInventoryItem> Items { get; private set; }

        [XmlElement(ElementName = "InventoryItem")]
        public ModelCharacterInventorycontainerInventoryItem[] ModelCharacterInventorycontainerInventoryItem
        {

            get
            {

                List<ModelCharacterInventorycontainerInventoryItem> List = new List<ModelCharacterInventorycontainerInventoryItem>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<int, ModelCharacterInventorycontainerInventoryItem>();

                if (value != null)
                {

                    foreach (ModelCharacterInventorycontainerInventoryItem Item in value)
                    {

                        Items.Add(Item.Index, Item);

                    }

                }

            }

        }
        
    }

}
