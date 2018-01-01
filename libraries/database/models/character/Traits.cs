using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character traits model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "traits")]
    public class ModelCharacterTraits
    {

        [XmlElement(ElementName = "trait")]
        public List<ModelCharacterTrait> Trait { get; set; }

    }

}
