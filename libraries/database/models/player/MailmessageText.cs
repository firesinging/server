using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail message text model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "message")]
    [DefaultValue(null)]
    public class ModelPlayerMailmessageText
    {

        public ModelPlayerMailmessageText()
        {

            Message = new ModelPlayerMailmessageTextMessage();

        }

        [XmlElement(ElementName = "m")]
        [DefaultValue(null)]
        public ModelPlayerMailmessageTextMessage Message { get; set; }

    }

}
