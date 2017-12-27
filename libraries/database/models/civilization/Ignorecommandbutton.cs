using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Ignore commandbutton model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ignorecommandbutton")]
    public class ModelCivilizationIgnorecommandbutton
    {

        [XmlAttribute(AttributeName = "protoname")]
        public string Protoname { get; set; }

        [XmlAttribute(AttributeName = "row")]
        public string Row { get; set; }

        [XmlAttribute(AttributeName = "column")]
        public string Column { get; set; }

    }

}
