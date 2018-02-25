using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.inventory.item;


namespace Libraries.database.models.inventory.item
{

    /// <summary>
    /// Advisors model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "advisors")]
    public class ModelInventoryItemAdvisors : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelInventoryItemAdvisors()
        {

            Items = new Dictionary<string, Advisor>();

        }

        [XmlIgnore]
        public Dictionary<string, Advisor> Items { get; private set; }

        [XmlElement(ElementName = "advisor")]
        public Advisor[] Advisor
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, Advisor>();

                foreach (Advisor Item in value)
                {

                    Items.Add(Item.Name, Item);

                }

            }

        }       

    }   

}
