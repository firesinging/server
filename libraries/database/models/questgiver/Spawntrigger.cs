using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Spawntrigger model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "spawntrigger")]
    public class ModelQuestgiverSpawntrigger
    {

        [XmlElement(ElementName = "onunitcount")]
        public ModelQuestgiverOnunitcount Onunitcount { get; set; }

        [XmlElement(ElementName = "onquest")]
        public ModelQuestgiverOnquest Onquest { get; set; }

    }

}
