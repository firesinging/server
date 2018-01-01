using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital resource model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "capitalresource")]
    public class ModelCharacterCapitalResource
    {

        [XmlAttribute(AttributeName = "resourcetype")]
        public string Resourcetype { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

    }

}
