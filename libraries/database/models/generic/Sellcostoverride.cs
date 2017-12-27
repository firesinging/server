using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Sellcostoverride model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "sellcostoverride")]
    public class ModelGenericSellcostoverride
    {

        [XmlElement(ElementName = "capitalresource")]
        public ModelGenericCapitalresource Capitalresource { get; set; }

    }

}