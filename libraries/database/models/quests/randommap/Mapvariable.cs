using System.Xml.Serialization;


namespace Libraries.database.models.randommap
{

    /// <summary>
    /// Variable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "variable")]
    public class ModelQuestRandommapMapvariable
    {

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
