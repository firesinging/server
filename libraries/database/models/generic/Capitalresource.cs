using System.Xml.Serialization;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Capital resource model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitalresource")]
    public class ModelGenericCapitalresource
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
