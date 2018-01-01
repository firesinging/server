using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Mail messages model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "MailMessages")]
    public class ModelEmpireMailmessages
    {

        [XmlAttribute(AttributeName = "totalmail")]
        public int Totalmail { get; set; }

        [XmlAttribute(AttributeName = "nextmsgid")]
        public long Nextmsgid { get; set; }

        [XmlElement(ElementName = "message")]
        public List<ModelEmpireMailmessage> Message { get; set; }

    }

}
