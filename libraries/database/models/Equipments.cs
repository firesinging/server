using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Equipments model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "equipmentdata")]
    public class ModelEquipments : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelEquipments()
        {

            Items = new Dictionary<int, ModelEquipment>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelEquipment> Items { get; private set; }

        [XmlElement(ElementName = "equipment")]
        public ModelEquipment[] ModelEquipment
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<int, ModelEquipment>();

                foreach (ModelEquipment Item in value)
                {

                    Items.Add(Item.Id, Item);

                }

            }

        }       

    }   

}
