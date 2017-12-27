using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Trait model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "trait")]
    public class ModelGenericTrait
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public string Level { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
