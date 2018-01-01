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
        public string Used { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

        [XmlAttribute(AttributeName = "seed")]
        public int Seed { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "serializationData")]
        public string SerializationData { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
