using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic advisor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "advisor")]
    public class ModelGenericAdvisor
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
