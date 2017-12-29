using System.Xml.Serialization;

using Libraries.helpers.xml;


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

            Dictionary = new SerDictionaryTraits<string, ModelTrait>();

        }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlIgnore]
        public SerDictionaryTraits<string, ModelTrait> Dictionary { get; private set; }

        [XmlElement(ElementName = "trait")]
        public ModelTrait[] ModelTrait
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryTraits<string, ModelTrait>();

                foreach (ModelTrait Item in value)
                {
                    
                    Dictionary.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
