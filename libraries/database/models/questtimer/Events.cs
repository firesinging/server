using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.timer
{

    /// <summary>
    /// Events model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "events")]
    public class ModelQuestTimerEvents
    {

        public ModelQuestTimerEvents()
        {

            Timerevent = new List<ModelQuestTimerEvent>();

        }

        [XmlElement(ElementName = "timerevent")]
        [DefaultValue(null)]
        public List<ModelQuestTimerEvent> Timerevent { get; set; }

    }

}
