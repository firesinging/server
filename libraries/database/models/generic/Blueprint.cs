using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic blueprint model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "blueprint")]
    public class ModelGenericBlueprint
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
