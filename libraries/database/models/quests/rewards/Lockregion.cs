using System.Xml.Serialization;


namespace Libraries.database.models.rewards
{

    /// <summary>
    /// Lockregion model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "lockregion")]
    public class ModelQuestRewardsLockregion
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
