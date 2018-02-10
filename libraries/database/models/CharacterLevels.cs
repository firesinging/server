using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Character levels model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "xplevels")]
    public class ModelCharacterLevels : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterLevels()
        {

            Items = new Dictionary<int, ModelCharacterLevel>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelCharacterLevel> Items { get; private set; }

        [XmlElement(ElementName = "maxlevel")]
        public int MaxLevel { get; set; }

        [XmlElement(ElementName = "level")]
        public ModelCharacterLevel[] ModelCharacterLevel
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<int, ModelCharacterLevel>();

                if (value != null)
                {

                    int Level = -1;

                    foreach (var Item in value)
                    {

                        Level++;

                        Items.Add(Level, Item);

                    }

                }

            }

        }

    }

}
