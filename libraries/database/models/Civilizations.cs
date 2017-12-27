using System.Xml.Serialization;

using Libraries.enums;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Civilizations model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "Civilization")]
    public class ModelCivilizations : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCivilizations()
        {

            Dictionary = new SerDictionaryCivilizations<Civilizations, ModelCivilization>();

        }

        public bool Test()
        {

            return true;

        }

        [XmlIgnore]
        public SerDictionaryCivilizations<Civilizations, ModelCivilization> Dictionary { get; private set; }

        [XmlElement(ElementName = "civ")]
        public ModelCivilization[] ModelCivilization
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryCivilizations<Civilizations, ModelCivilization>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Dictionary.Add(Item.CivId, Item);

                    }

                }

            }

        }        

    }

    

}
