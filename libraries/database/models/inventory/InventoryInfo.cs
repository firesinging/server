using System.Xml.Serialization;


namespace Libraries.database.models.inventory
{

    /// <summary>
    /// Inventory info model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "info")]
    public class ModelInventoryInfo
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "maxcapacity")]
        public int Maxcapacity { get; set; }

    }

}
