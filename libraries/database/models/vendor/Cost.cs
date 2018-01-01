using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelVendorCost
    {

        [XmlElement(ElementName = "capitalresource")]
        public ModelGenericCapitalresource Capitalresource { get; set; }

        [XmlElement(ElementName = "gamecurrency")]
        public ModelGenericGamecurrency Gamecurrency { get; set; }

    }

}
