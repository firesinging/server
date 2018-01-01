using System.Xml.Serialization;


namespace Libraries.database.models.quest.randommap
{

    /// <summary>
    /// Nuggetoverrides model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "nuggetoverrides")]
    public class ModelQuestRandommapNuggetoverrides
    {

        [XmlElement(ElementName = "nuggetoverride")]
        public ModelQuestRandommapNuggetoverride Nuggetoverride { get; set; }

    }

}
