using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.inventory.item;


namespace Libraries.database.models.inventory.item
{

    /// <summary>
    /// Consumables model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "consumables")]
    public class ModelInventoryItemConsumables : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryItemConsumables()
        {

            Items = new Dictionary<string, Consumable>();

        }

        [XmlIgnore]
        public Dictionary<string, Consumable> Items { get; private set; }

        [XmlElement(ElementName = "consumable")]
        public Consumable[] Consumable
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, Consumable>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
