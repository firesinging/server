using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Designs model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "econdesigns")]
    public class ModelDesigns : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelDesigns()
        {

            Items = new Dictionary<string, ModelDesign>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelDesign> Items { get; private set; }

        [XmlElement(ElementName = "econdesign")]
        public ModelDesign[] ModelDesign
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelDesign>();

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
