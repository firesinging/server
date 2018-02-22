using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.quest;


namespace Libraries.database.models
{

    /// <summary>
    /// Nuggets model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "nuggets")]
    public class ModelNuggets : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelNuggets()
        {

            Items = new Dictionary<int, QuestNugget>();

        }

        [XmlIgnore]
        public Dictionary<int, QuestNugget> Items { get; private set; }

        [XmlElement(ElementName = "nugget")]
        public QuestNugget[] QuestNugget
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<int, QuestNugget>();

                if (value != null)
                {

                    foreach (QuestNugget Item in value)
                    {

                        Items.Add(Item.Dbid, Item);

                    }

                }

            }

        }

    }

}
