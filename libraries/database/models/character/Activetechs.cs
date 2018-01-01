using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character active techs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "activetechs")]
    public class ModelCharacterTechsActive
    {

        [XmlElement(ElementName = "activetech")]
        public List<ModelCharacterTechActive> Activetech { get; set; }

    }

}
