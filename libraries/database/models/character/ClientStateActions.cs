using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientstate actions model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "actions")]
    public class ModelCharacterClientStateActions
    {

        public ModelCharacterClientStateActions()
        {

            Items = new List<ModelCharacterClientStateAction>();            

        }

        [XmlElement(ElementName = "action")]
        [DefaultValue(null)]
        public List<ModelCharacterClientStateAction> Items { get; set; }

    }

}
