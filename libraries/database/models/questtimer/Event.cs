using System.Xml.Serialization;


namespace Libraries.database.models.timer
{

    /// <summary>
    /// Event model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "event")]
    public class ModelQuestTimerEvent
    {

        [XmlAttribute(AttributeName = "event")]
        public string Event { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
