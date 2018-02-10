using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Materials model
    /// </summary>
    /// <seealso cref="https://github.com/yrtimiD/osm-api-dotnet/blob/64554550da0a13e4e24766b27a8b525d9d325ba4/OSM.API.v6/OSM.API.v6/v6/Osm.cs"/>

    [XmlRoot(ElementName = "materials")]
    public class ModelMaterials : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelMaterials()
        {

            Items = new Dictionary<string, ModelMaterial>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelMaterial> Items { get; private set; }

        [XmlElement(ElementName = "material")]
        public ModelMaterial[] ModelMaterial
        {

            get
            {

                return null;

            }

            set
            {

                Items = new Dictionary<string, ModelMaterial>();

                if (value != null)
                {

                    foreach (ModelMaterial Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
