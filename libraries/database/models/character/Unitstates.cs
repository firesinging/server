using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character unitstates model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unitStates")]
    public class ModelCharacterUnitStates
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterUnitStates()
        {

            Items = new Dictionary<string, ModelCharacterUnitState>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterUnitState> Items { get; private set; }

        [XmlElement(ElementName = "unitState")]
        public ModelCharacterUnitState[] ModelCharacterUnitState
        {

            get
            {

                List<ModelCharacterUnitState> List = new List<ModelCharacterUnitState>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterUnitState>();

                if (value != null)
                {

                    foreach (ModelCharacterUnitState Item in value)
                    {

                        Items.Add(Item.Unitname, Item);

                    }

                }

            }

        }

    }

}
