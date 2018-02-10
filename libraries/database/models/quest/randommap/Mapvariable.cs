using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.quest.randommap
{

    /// <summary>
    /// Variable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "variable")]
    public class ModelQuestRandommapMapvariable
    {

        [XmlAttribute(AttributeName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
