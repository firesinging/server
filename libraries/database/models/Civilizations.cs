using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.enums;


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

            Items = new Dictionary<Civilizations, ModelCivilization>();

        }

        [XmlIgnore]
        public Dictionary<Civilizations, ModelCivilization> Items { get; private set; }

        [XmlElement(ElementName = "civ")]
        public ModelCivilization[] ModelCivilization
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<Civilizations, ModelCivilization>();

                if (value != null)
                {

                    foreach (var Item in value)
                    {

                        Items.Add(Item.CivId, Item);

                    }

                }

            }

        }        

    }

    

}
