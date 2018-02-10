using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail message item model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "item")]
    [DefaultValue(null)]
    public class ModelPlayerMailmessageItem
    {

        [XmlAttribute(AttributeName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "itemcount")]
        public int Itemcount { get; set; }

        [XmlAttribute(AttributeName = "attachmentid")]
        public long AttachmentId { get; set; }

        [XmlAttribute(AttributeName = "itemlevel")]
        public int Itemlevel { get; set; }

        [XmlAttribute(AttributeName = "itemseed")]
        public int Itemseed { get; set; }

    }

}
