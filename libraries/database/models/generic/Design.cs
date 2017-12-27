using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic design model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "design")]
    public class ModelGenericDesign
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
