using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character resources model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "resources")]
    public class ModelCharacterResources
    {

        [XmlElement(ElementName = "resource")]
        public List<ModelCharacterResource> Resource { get; set; }

    }

}
