using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientState model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "clientState")]
    public class ModelCharacterClientState
    {

        [XmlElement(ElementName = "tasks")]
        public string Tasks { get; set; }

        [XmlAttribute(AttributeName = "unitname")]
        public string Unitname { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "position")]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "rotation")]
        public string Rotation { get; set; }

        [XmlAttribute(AttributeName = "variation")]
        public string Variation { get; set; }

        [XmlAttribute(AttributeName = "buildPoints")]
        public string BuildPoints { get; set; }

        [XmlElement(ElementName = "actions")]
        public ModelCharacterClientStateActions Actions { get; set; }


    }

}
