using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail message text message model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    [DefaultValue(null)]
    public class ModelPlayerMailmessageTextMessage
    {

        [XmlText]
        [DefaultValue(null)]
        public string Message { get; set; }

    }

}
