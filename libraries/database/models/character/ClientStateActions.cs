using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientstate actions model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "actions")]
    public class ModelCharacterClientStateActions
    {

        [XmlElement(ElementName = "action")]
        public List<ModelCharacterClientStateAction> Action { get; set; }

    }

}
