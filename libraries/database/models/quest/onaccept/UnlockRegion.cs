using System.Xml.Serialization;


namespace Libraries.database.models.quest.onaccept
{

    /// <summary>
    /// UnlockRegion model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockregion")]
    public class ModelQuestOnacceptUnlockRegion
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public int Id { get; set; }

    }

}
