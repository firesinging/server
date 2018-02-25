using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.inventory.item;


namespace Libraries.database.models.inventory.item
{

    /// <summary>
    /// Blueprints model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "blueprints")]
    public class ModelInventoryItemBlueprints : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryItemBlueprints()
        {

            Items = new Dictionary<string, Blueprint>();

        }

        [XmlIgnore]
        public Dictionary<string, Blueprint> Items { get; private set; }

        [XmlElement(ElementName = "blueprint")]
        public Blueprint[] Blueprint
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, Blueprint>();

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
