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

            Dictionary = new SerDictionaryRegions<int, ModelRegion>();

        }

        public bool Test()
        {

            return true;

        }

        [XmlIgnore]
        public SerDictionaryRegions<int, ModelRegion> Dictionary { get; private set; }

        [XmlElement(ElementName = "Region")]
        public ModelRegion[] ModelRegion
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryRegions<int, ModelRegion>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Dictionary.Add(Item.Id, Item);

                    }

                }

            }

        }        

    }

    

}
