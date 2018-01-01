using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital resources model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitalresources")]
    public class ModelCharacterCapitalResources
    {

        [XmlElement(ElementName = "capitalresource")]
        public List<ModelCharacterCapitalResource> Capitalresource { get; set; }

    }

}
