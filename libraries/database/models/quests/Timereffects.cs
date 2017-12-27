using System.Xml.Serialization;

using Libraries.database.models.timereffects;


namespace Libraries.database.models
{

    /// <summary>
    /// Timereffects model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "timereffects")]
    public class ModelQuestTimereffects
    {

        [XmlElement(ElementName = "spawnunit")]
        public ModelQuestTimereffectsSpawnunit Spawnunit { get; set; }

        [XmlAttribute(AttributeName = "event")]
        public string Event { get; set; }

    }

}
