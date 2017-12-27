using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.timer
{

    /// <summary>
    /// Events model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "events")]
    public class ModelQuestTimerEvents
    {

        [XmlElement(ElementName = "timerevent")]
        public List<ModelQuestTimerEvent> Timerevent { get; set; }

    }

}
