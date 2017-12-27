using System.Xml.Serialization;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Questgivers model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "questgivers")]
    public class ModelQuestgivers : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelQuestgivers()
        {

            Dictionary = new SerDictionaryQuestgivers<string, ModelQuestgiver>();

        }

        [XmlIgnore]
        public SerDictionaryQuestgivers<string, ModelQuestgiver> Dictionary { get; private set; }

        [XmlElement(ElementName = "questgiver")]
        public ModelQuestgiver[] ModelQuestgiver
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryQuestgivers<string, ModelQuestgiver>();

                foreach (ModelQuestgiver Item in value)
                {

                    Dictionary.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
