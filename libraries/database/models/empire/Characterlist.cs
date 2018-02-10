using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Character list model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "CharacterList")]
    public class ModelEmpireCharacterlist
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelEmpireCharacterlist() 
        {

            Items = new Dictionary<long, ModelEmpireCharacterlistCharacterData>();

        }

        [XmlIgnore]
        public Dictionary<long, ModelEmpireCharacterlistCharacterData> Items { get; private set; }

        [XmlElement(ElementName = "CharacterData")]
        public ModelEmpireCharacterlistCharacterData[] ModelEmpireCharacterlistCharacterData
        {

            get
            {

                List<ModelEmpireCharacterlistCharacterData> List = new List<ModelEmpireCharacterlistCharacterData>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }                   

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<long, ModelEmpireCharacterlistCharacterData>();

                if (value != null)
                {

                    foreach (ModelEmpireCharacterlistCharacterData Item in value)
                    {

                        Items.Add(Item.CharacterId, Item);

                    }

                }
                    
            }

        }
        
    }

}
