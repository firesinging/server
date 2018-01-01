using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization ignore commandbutton model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ignorecommandbutton")]
    public class ModelCivilizationIgnorecommandbutton
    {

        [XmlAttribute(AttributeName = "protoname")]
        [DefaultValue(null)]
        public string Protoname { get; set; }

        [XmlAttribute(AttributeName = "row")]
        public int Row { get; set; }

        [XmlAttribute(AttributeName = "column")]
        public int Column { get; set; }

    }

}
