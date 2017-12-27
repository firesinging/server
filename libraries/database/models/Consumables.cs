using System.Xml.Serialization;

using Libraries.helpers.xml;


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

            Dictionary = new SerDictionaryConsumables<string, ModelConsumable>();

        }

        [XmlIgnore]
        public SerDictionaryConsumables<string, ModelConsumable> Dictionary { get; private set; }

        [XmlElement(ElementName = "consumable")]
        public ModelConsumable[] ModelConsumable
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryConsumables<string, ModelConsumable>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Dictionary.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
