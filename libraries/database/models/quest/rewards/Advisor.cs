using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Advisor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "advisor")]
    public class ModelQuestRewardsAdvisor
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }


    }

}
