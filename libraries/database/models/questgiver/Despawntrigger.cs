using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Despawntrigger model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "despawntrigger")]
    public class ModelQuestgiverDespawntrigger
    {

        [XmlElement(ElementName = "onunitcount")]
        public ModelQuestgiverOnunitcount Onunitcount { get; set; }

    }

}
