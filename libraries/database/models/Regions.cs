using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Libraries.helpers.xml;

namespace Libraries.database.models
{

    /// <summary>
    /// Regions model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "Regions")]
    public class ModelRegions : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelRegions()
        {

            Items = new SerDictionaryRegions<int, ModelRegion>();

        }

        [XmlIgnore]
        public SerDictionaryRegions<int, ModelRegion> Items { get; private set; }

        [XmlElement(ElementName = "Region")]
        public ModelRegion[] ModelRegion
        {

            get
            {

                return null;

            }

            set
            {

                Items = new SerDictionaryRegions<int, ModelRegion>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Items.Add(Item.Id, Item);

                    }

                }

            }

        }        

    }

    

}
