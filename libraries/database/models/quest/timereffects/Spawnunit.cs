using System.Xml.Serialization;


namespace Libraries.database.models.quest.timereffects
{

    /// <summary>
    /// Spawnunit model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "spawnunit")]
    public class ModelQuestTimereffectsSpawnunit
    {

        [XmlElement(ElementName = "count")]
        public string Count { get; set; }

        [XmlElement(ElementName = "placeunittype")]
        public string Placeunittype { get; set; }

        [XmlElement(ElementName = "asplayer")]
        public string Asplayer { get; set; }

        [XmlElement(ElementName = "spawntype")]
        public string Spawntype { get; set; }

        [XmlElement(ElementName = "nearunittype")]
        public string Nearunittype { get; set; }

        [XmlElement(ElementName = "radius")]
        public string Radius { get; set; }

        [XmlElement(ElementName = "useboneposition")]
        public string Useboneposition { get; set; }

        [XmlElement(ElementName = "overrides")]
        public string Overrides { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
