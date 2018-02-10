using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Quest instances model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questinstances")]
    public class ModelQuestinstances : ModelBase
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelQuestinstances()
        {

            Items = new Dictionary<int, ModelQuestinstance>();

        }

        [XmlIgnore]
        public Dictionary<int, ModelQuestinstance> Items { get; private set; }

        [XmlElement(ElementName = "questinstance")]
        public ModelQuestinstance[] ModelQuestinstance
        {

            get
            {

                List<ModelQuestinstance> List = new List<ModelQuestinstance>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<int, ModelQuestinstance>();

                if (value != null)
                {

                    foreach (ModelQuestinstance Item in value)
                    {

                        Items.Add(Item.Id, Item);

                    }

                }

            }

        }

    }

}
