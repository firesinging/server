using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Trait model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "trait")]
    public class ModelQuestRewardsTrait
    {

        [XmlElement(ElementName = "traitlevel")]
        public int Traitlevel { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }


    }

}
