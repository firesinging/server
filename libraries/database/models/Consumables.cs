using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Consumables model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "consumables")]
    public class ModelConsumables : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelConsumables()
        {

            Items = new Dictionary<string, ModelConsumable>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelConsumable> Items { get; private set; }

        [XmlElement(ElementName = "consumable")]
        public ModelConsumable[] ModelConsumable
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelConsumable>();

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
