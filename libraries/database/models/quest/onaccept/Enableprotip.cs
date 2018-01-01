using System.Xml.Serialization;


namespace Libraries.database.models.quest.onaccept
{

    /// <summary>
    /// Enableprotip model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "enableprotip")]
    public class ModelQuestOnacceptEnableprotip
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
