using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Traits model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "traits")]
    public class ModelTraits : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelTraits()
        {

            Items = new Dictionary<string, ModelTrait>();

        }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlIgnore]
        public Dictionary<string, ModelTrait> Items { get; private set; }

        [XmlElement(ElementName = "trait")]
        public ModelTrait[] ModelTrait
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelTrait>();

                foreach (ModelTrait Item in value)
                {

                    Items.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
