using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character configs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "characterconfigs")]
    public class ModelCharacterConfigs
    {

        [XmlElement(ElementName = "characterconfig")]
        public List<ModelCharacterConfig> Config { get; set; }

    }

}
