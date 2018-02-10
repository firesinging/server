using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital resources model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitalresources")]
    public class ModelCharacterCapitalResources : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterCapitalResources()
        {

            Items = new Dictionary<string, ModelCharacterCapitalResource>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterCapitalResource> Items { get; private set; }

        [XmlElement(ElementName = "capitalresource")]
        public ModelCharacterCapitalResource[] ModelCharacterCapitalResource
        {

            get
            {

                List<ModelCharacterCapitalResource> List = new List<ModelCharacterCapitalResource>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterCapitalResource>();

                if (value != null)
                {

                    foreach (ModelCharacterCapitalResource Item in value)
                    {

                        Items.Add(Item.Resourcetype, Item);

                    }

                }

            }

        }

    }

}
