using System.Xml.Serialization;


namespace Libraries.database.models.quest.onaccept
{

    /// <summary>
    /// Protip model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "protip")]
    public class ModelQuestOnacceptProtip
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
