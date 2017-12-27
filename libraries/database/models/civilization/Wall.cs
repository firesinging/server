using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Wall model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "wall")]
    public class ModelCivilizationWall
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
