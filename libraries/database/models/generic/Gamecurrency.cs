using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Game currency model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrency")]
    public class ModelGenericGamecurrency
    {

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
