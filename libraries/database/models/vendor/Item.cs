using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Item model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "item")]
    public class ModelVendorItem
    {

        [XmlElement(ElementName = "purchase")]
        public ModelVendorPurchase Purchase { get; set; }

        [XmlElement(ElementName = "cost")]
        public ModelVendorCost Cost { get; set; }

    }

}
