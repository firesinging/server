using System.Xml.Serialization;

using Libraries.database.models.quest.timereffects;


namespace Libraries.database.models.quest
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
