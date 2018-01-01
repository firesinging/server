using System.Xml.Serialization;


namespace Libraries.database.models.quest.onaccept
{

    /// <summary>
    /// Blueprint model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "blueprint")]
    public class ModelQuestOnacceptBlueprint
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
