using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic material model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "material")]
    public class ModelGenericMaterial
    {

        [XmlAttribute(AttributeName = "quantity")]
        [DefaultValue(null)]
        public string Quantity { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
