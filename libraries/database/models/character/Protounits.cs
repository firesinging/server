using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character protounits model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "protounits")]
    public class ModelCharacterProtounits
    {

        [XmlElement(ElementName = "protounit")]
        public List<string> Protounit { get; set; }

    }

}
