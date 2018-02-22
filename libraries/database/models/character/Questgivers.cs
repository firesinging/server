using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

using Libraries.character;


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

            Items = new Dictionary<string, CharacterQuestgiver>();

        }

        [XmlIgnore]
        public Dictionary<string, CharacterQuestgiver> Items { get; private set; }

        [XmlElement(ElementName = "questgiver")]
        public CharacterQuestgiver[] CharacterQuestgiver
        {

            get
            {

                List<CharacterQuestgiver> List = new List<CharacterQuestgiver>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, CharacterQuestgiver>();

                if (value != null)
                {

                    foreach (CharacterQuestgiver Item in value)
                    {

                        Items.Add(Item.Name, Item);

                    }

                }

            }

        }

    }

}
