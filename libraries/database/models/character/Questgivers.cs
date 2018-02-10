using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character questgivers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgivers")]
    public class ModelCharacterQuestgivers : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterQuestgivers()
        {

            Items = new Dictionary<string, ModelCharacterQuestgiver>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterQuestgiver> Items { get; private set; }

        [XmlElement(ElementName = "questgiver")]
        public ModelCharacterQuestgiver[] ModelEmpireGamecurrency
        {

            get
            {

                List<ModelCharacterQuestgiver> List = new List<ModelCharacterQuestgiver>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterQuestgiver>();

                if (value != null)
                {

                    foreach (ModelCharacterQuestgiver Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
