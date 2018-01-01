using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Mail message text model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    public class ModelEmpireMailmessageText
    {

        [XmlElement(ElementName = "m")]
        public ModelEmpireMailmessageTextMessage Message { get; set; }

    }

}
