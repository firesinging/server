using System.Xml.Serialization;

using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Advisors model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "advisors")]
    public class ModelAdvisors : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelAdvisors()
        {

            Dictionary = new SerDictionaryAdvisors<string, ModelAdvisor>();

        }

        [XmlIgnore]
        public SerDictionaryAdvisors<string, ModelAdvisor> Dictionary { get; private set; }

        [XmlElement(ElementName = "advisor")]
        public ModelAdvisor[] ModelAdvisor
        {

            get
            {

                return null;

            }

            set
            {

                Dictionary = new SerDictionaryAdvisors<string, ModelAdvisor>();

                foreach (ModelAdvisor Item in value)
                {

                    Dictionary.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
