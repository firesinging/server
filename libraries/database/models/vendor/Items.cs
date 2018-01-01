using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelVendorItems
    {

        [XmlElement(ElementName = "item")]
        public List<ModelVendorItem> Item { get; set; }

    }

}
