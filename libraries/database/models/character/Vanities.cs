using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character vanities model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "vanitys")]
    public class ModelCharacterVanities
    {

        [XmlElement(ElementName = "vanity")]
        public List<ModelCharacterVanity> Vanity { get; set; }

    }

}
