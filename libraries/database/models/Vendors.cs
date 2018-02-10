using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Vendors model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "vendors")]
    public class ModelVendors : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelVendors()
        {

            Items = new Dictionary<string, ModelVendor>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelVendor> Items { get; private set; }

        [XmlElement(ElementName = "vendor")]
        public ModelVendor[] ModelVendor
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelVendor>();

                if (value != null)
                {

                    foreach (ModelVendor Item in value)
                    {

                        Items.Add(Item.Protounit, Item);

                    }

                }

            }

        }

    }

}
