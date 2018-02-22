using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character unitstate model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unitState")]
    public class ModelCharacterUnitState
    {

        public ModelCharacterUnitState()
        {

            Client = new ModelCharacterUnitStateClient();
            Server = new ModelCharacterUnitStateServer();

        }

        [XmlAttribute(AttributeName = "unitname")]
        public string Unitname { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlElement(ElementName = "clientState")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateClient Client { get; set; }

        [XmlElement(ElementName = "serverState")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateServer Server { get; set; }

    }

}
