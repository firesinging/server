using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character traits model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "traits")]
    public class ModelCharacterTraits : ModelBase
    {

        public ModelCharacterTraits()
        {

            Items = new List<ModelCharacterTrait>();

        }

        [XmlElement(ElementName = "trait")]
        [DefaultValue(null)]
        public List<ModelCharacterTrait> Items { get; set; }

    }

}
