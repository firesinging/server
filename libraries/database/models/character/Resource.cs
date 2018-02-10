using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character resource model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "resource")]
    public class ModelCharacterResource
    {

        [XmlAttribute(AttributeName = "resourcetype")]
        public string Resourcetype { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

    }

}
