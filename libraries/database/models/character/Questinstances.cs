using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.quest;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Quest instances model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questinstances")]
    public class ModelCharacterQuestinstances : ModelBase
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterQuestinstances()
        {

            Items = new Dictionary<int, QuestInstance>();

        }

        [XmlIgnore]
        public Dictionary<int, QuestInstance> Items { get; private set; }

        [XmlElement(ElementName = "questinstance")]
        public QuestInstance[] QuestInstance
        {

            get
            {

                List<QuestInstance> List = new List<QuestInstance>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<int, QuestInstance>();

                if (value != null)
                {

                    foreach (QuestInstance Item in value)
                    {

                        Items.Add(Item.Id, Item);

                    }

                }

            }

        }

    }

}
