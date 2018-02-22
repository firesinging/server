using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Nuggets model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "nuggetlogic")]
    public class ModelNuggetLogics : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelNuggetLogics()
        {

            Items = new Dictionary<string, ModelNuggetLogic>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelNuggetLogic> Items { get; private set; }

        [XmlElement(ElementName = "randommapregion")]
        public ModelNuggetLogic[] ModelNuggetLogic
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelNuggetLogic>();

                if (value != null)
                {

                    foreach (ModelNuggetLogic Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
