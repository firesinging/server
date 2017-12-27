using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic quest model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "quest")]
    public class ModelGenericQuest
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
