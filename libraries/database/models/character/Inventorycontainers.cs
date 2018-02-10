using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory containers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainers")]
    public class ModelCharacterInventoryContainers
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterInventoryContainers()
        {

            Items = new Dictionary<string, ModelCharacterInventorycontainer>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterInventorycontainer> Items { get; private set; }

        [XmlElement(ElementName = "inventorycontainer")]
        public ModelCharacterInventorycontainer[] ModelCharacterInventorycontainer
        {

            get
            {

                List<ModelCharacterInventorycontainer> List = new List<ModelCharacterInventorycontainer>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterInventorycontainer>();

                if (value != null)
                {

                    foreach (ModelCharacterInventorycontainer Item in value)
                    {

                        Items.Add(Item.Info.Id, Item);

                    }

                }

            }

        }

    }

}
