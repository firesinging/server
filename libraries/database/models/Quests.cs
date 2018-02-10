using System.Collections.Generic;
using System.Xml.Serialization;

namespace Libraries.database.models
{

    /// <summary>
    /// Quests model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "quests")]
    public class ModelQuests : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelQuests()
        {

            Items = new Dictionary<int, ModelQuest>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelQuest> Items { get; private set; }

        [XmlElement(ElementName = "quest")]
        public ModelQuest[] ModelQuest
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<int, ModelQuest>();

                foreach (ModelQuest Item in value)
                {

                    Items.Add(Item.Id, Item);

                }

            }

        }       

    }   

}
