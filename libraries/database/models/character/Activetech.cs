using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character active tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "activetech")]
    public class ModelCharacterTechActive
    {

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "persistentcitystatus")]
        public string Persistentcitystatus { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
