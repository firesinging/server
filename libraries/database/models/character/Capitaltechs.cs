using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital techs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitaltechs")]
    public class ModelCharacterTechsCapital : ModelBase
    {

        public ModelCharacterTechsCapital()
        {

            Items = new List<ModelCharacterTechCapital>();

        }

        [XmlElement(ElementName = "item")]
        [DefaultValue(null)]
        public List<ModelCharacterTechCapital> Items { get; set; }

    }

}
