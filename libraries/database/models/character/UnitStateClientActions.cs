using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate actions model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "actions")]
    public class ModelCharacterUnitStateClientActions
    {
        
        public ModelCharacterUnitStateClientActions()
        {

            Items = new List<ModelCharacterUnitStateClientAction>();            

        }

        [XmlElement(ElementName = "action")]
        [DefaultValue(null)]
        public List<ModelCharacterUnitStateClientAction> Items { get; set; }

    }

}
