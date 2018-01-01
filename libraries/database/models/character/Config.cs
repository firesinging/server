using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character config model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "characterconfig")]
    public class ModelCharacterConfig
    {

        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

    }

}
