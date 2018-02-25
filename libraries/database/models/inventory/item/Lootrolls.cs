using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.inventory.item;


namespace Libraries.database.models.inventory.item
{

    /// <summary>
    /// Loot rolls model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "lootrolls")]
    public class ModelInventoryItemLootrolls : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryItemLootrolls()
        {

            Items = new Dictionary<string, Lootroll>();

        }

        [XmlIgnore]
        public Dictionary<string, Lootroll> Items { get; private set; }

        [XmlElement(ElementName = "lootroll")]
        public Lootroll[] Lootroll
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, Lootroll>();

                if (value != null)
                {

                    foreach (Lootroll Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
