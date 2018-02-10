using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character protounits model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "protounits")]
    public class ModelCharacterProtounits : ModelBase
    {

        public ModelCharacterProtounits()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
