using System.Xml.Serialization;


namespace Libraries.database.models.quest.randommap
{

    /// <summary>
    /// Nuggetoverride model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "nuggetoverride")]
    public class ModelQuestRandommapNuggetoverride
    {

        [XmlAttribute(AttributeName = "overrideweight")]
        public string Overrideweight { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
