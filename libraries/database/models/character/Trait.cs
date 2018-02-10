using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character trait model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "trait")]
    public class ModelCharacterTrait
    {

        [XmlAttribute(AttributeName = "used")]
        [DefaultValue(null)]
        public string Used { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

        [XmlAttribute(AttributeName = "seed")]
        public int Seed { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "serializationData")]
        [DefaultValue(null)]
        public string SerializationData { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
