using System.Xml.Serialization;

using Libraries.database.models.timer;


namespace Libraries.database.models
{

    /// <summary>
    /// Quest timer model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "timer")]
    public class ModelQuestTimer
    {

        [XmlElement(ElementName = "time")]
        public string Time { get; set; }

        [XmlElement(ElementName = "events")]
        public ModelQuestTimerEvents Events { get; set; }

        [XmlElement(ElementName = "hideonui")]
        public string Hideonui { get; set; }

    }

}
