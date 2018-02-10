using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character configs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "characterconfigs")]
    public class ModelCharacterConfigs : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterConfigs()
        {

            Items = new Dictionary<string, ModelCharacterConfig>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterConfig> Items { get; private set; }

        [XmlElement(ElementName = "characterconfig")]
        public ModelCharacterConfig[] ModelCharacterConfig
        {

            get
            {

                List<ModelCharacterConfig> List = new List<ModelCharacterConfig>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterConfig>();

                if (value != null)
                {

                    foreach (ModelCharacterConfig Item in value)
                    {

                        Items.Add(Item.Key, Item);

                    }

                }

            }

        }

    }

}
