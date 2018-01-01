using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Enableprotip model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "enableprotip")]
    public class ModelQuestRewardsEnableprotip
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
