using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character active techs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "activetechs")]
    public class ModelCharacterTechsActive : ModelBase
    {

        public ModelCharacterTechsActive()
        {

            Items = new List<ModelCharacterTechActive>();

        }

        [XmlElement(ElementName = "activetech")]
        [DefaultValue(null)]
        public List<ModelCharacterTechActive> Items { get; set; }

    }

}
