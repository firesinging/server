using System.Collections.Generic;
using System.Xml.Serialization;


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

            Items = new Dictionary<string, ModelQuestgiver>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelQuestgiver> Items { get; private set; }

        [XmlElement(ElementName = "questgiver")]
        public ModelQuestgiver[] ModelQuestgiver
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelQuestgiver>();

                foreach (ModelQuestgiver Item in value)
                {

                    Items.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
