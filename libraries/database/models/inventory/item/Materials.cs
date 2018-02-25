using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.inventory.item;


namespace Libraries.database.models.inventory.item
{

    /// <summary>
    /// Materials model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "materials")]
    public class ModelInventoryItemMaterials : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryItemMaterials()
        {

            Items = new Dictionary<string, Material>();

        }

        [XmlIgnore]
        public Dictionary<string, Material> Items { get; private set; }

        [XmlElement(ElementName = "material")]
        public Material[] Material
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, Material>();

                if (value != null)
                {

                    foreach (Material Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
