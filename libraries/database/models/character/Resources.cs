using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character resources model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "resources")]
    public class ModelCharacterResources : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterResources()
        {

            Items = new Dictionary<string, ModelCharacterResource>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterResource> Items { get; private set; }

        [XmlElement(ElementName = "resource")]
        public ModelCharacterResource[] ModelCharacterResource
        {

            get
            {

                List<ModelCharacterResource> List = new List<ModelCharacterResource>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterResource>();

                if (value != null)
                {

                    foreach (ModelCharacterResource Item in value)
                    {

                        Items.Add(Item.Resourcetype, Item);

                    }

                }

            }

        }

    }

}
