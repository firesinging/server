using System.ComponentModel;
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
        [DefaultValue(null)]
        public string Event { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
