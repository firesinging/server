using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Mail message text message model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    public class ModelEmpireMailmessageTextMessage
    {

        [XmlText]
        public string Message { get; set; }

    }

}
