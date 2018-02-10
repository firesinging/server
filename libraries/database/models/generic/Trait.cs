using System.ComponentModel;
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
        public int Quantity { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public int Level { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
