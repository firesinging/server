using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character vanities model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "vanitys")]
    public class ModelCharacterVanities : ModelBase
    {

        public ModelCharacterVanities()
        {

            Items = new List<ModelCharacterVanity>();

        }

        [XmlElement(ElementName = "vanity")]
        [DefaultValue(null)]
        public List<ModelCharacterVanity> Items { get; set; }

    }

}
