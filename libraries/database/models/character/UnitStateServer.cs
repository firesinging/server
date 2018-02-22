using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character server unitstate model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "serverState")]
    public class ModelCharacterUnitStateServer : ModelBase
    {

        [XmlAttribute(AttributeName = "unitname")]
        public string UnitName { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        [DefaultValue(null)]
        public string ProtoUnit { get; set; }

        [XmlAttribute(AttributeName = "alive")]
        public int Alive { get; set; }

    }

}
