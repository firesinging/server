using System.ComponentModel;
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
        [DefaultValue(null)]
        public string Quantity { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
