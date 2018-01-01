using System.Xml.Serialization;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool allowed capitals model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "allowedcapitals")]
    public class ModelCraftschoolAllowedcapitals
    {

        [XmlElement(ElementName = "capital")]
        public string Capital { get; set; }

    }

}
