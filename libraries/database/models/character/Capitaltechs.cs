using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital techs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitaltechs")]
    public class ModelCharacterTechsCapital
    {

        [XmlElement(ElementName = "item")]
        public List<ModelCharacterTechCapital> Capitaltech { get; set; }

    }

}
