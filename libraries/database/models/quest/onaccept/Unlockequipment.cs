using System.Xml.Serialization;


namespace Libraries.database.models.quest.onaccept
{

    /// <summary>
    /// Unlockequipment model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockequipment")]
    public class ModelQuestOnacceptUnlockequipment
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
