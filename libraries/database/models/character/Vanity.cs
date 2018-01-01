using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character vanity model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "vanity")]
    public class ModelCharacterVanity
    {

        [XmlAttribute(AttributeName = "owned")]
        public string Owned { get; set; }

        [XmlAttribute(AttributeName = "applied")]
        public string Applied { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
