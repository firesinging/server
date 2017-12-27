using System.Xml.Serialization;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Loot rolls model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "lootrolls")]
    public class ModelLootRolls : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelLootRolls()
        {

            Dictionary = new SerDictionaryLootRolls<string, ModelLootRoll>();

        }

        [XmlIgnore]
        public SerDictionaryLootRolls<string, ModelLootRoll> Dictionary { get; private set; }

        [XmlElement(ElementName = "lootroll")]
        public ModelLootRoll[] ModelLootRoll
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryLootRolls<string, ModelLootRoll>();

                if (value != null)
                {

                    foreach (ModelLootRoll Item in value)
                    {

                        Dictionary.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
