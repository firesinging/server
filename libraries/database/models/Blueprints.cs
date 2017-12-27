using System.Xml.Serialization;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Blueprints model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "blueprints")]
    public class ModelBlueprints : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelBlueprints()
        {

            Dictionary = new SerDictionaryBlueprints<string, ModelBlueprint>();

        }

        [XmlIgnore]
        public SerDictionaryBlueprints<string, ModelBlueprint> Dictionary { get; private set; }

        [XmlElement(ElementName = "blueprint")]
        public ModelBlueprint[] ModelBlueprint
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryBlueprints<string, ModelBlueprint>();

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
