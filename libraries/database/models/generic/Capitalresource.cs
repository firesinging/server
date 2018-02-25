using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


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
        public double Quantity { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public CapitalResourceTypes Type { get; set; }

    }

}
