using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

using Libraries.inventory;


namespace Libraries.database.models
{

    /// <summary>
    /// Inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainers")]
    public class ModelInventories
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventories()
        {

            Items = new Dictionary<string, Inventory>();

        }

        [XmlIgnore]
        public Dictionary<string, Inventory> Items { get; private set; }

        [XmlElement(ElementName = "inventorycontainer")]
        public Inventory[] Inventory
        {

            get
            {

                List<Inventory> List = new List<Inventory>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, Inventory>();

                if (value != null)
                {

                    foreach (Inventory Item in value)
                    {

                        Items.Add(Item.Info.Id, Item);

                    }

                }

            }

        }

    }

}
