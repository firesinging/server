using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Craftschools model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "craftschools")]
    public class ModelCraftschools : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCraftschools()
        {

            Items = new Dictionary<string, ModelCraftschool>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCraftschool> Items { get; private set; }

        [XmlElement(ElementName = "school")]
        public ModelCraftschool[] ModelCraftschool
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelCraftschool>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Items.Add(Item.Tag, Item);

                    }

                }

            }

        }

    }

}
