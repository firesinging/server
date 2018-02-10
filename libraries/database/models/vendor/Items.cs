using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelVendorItems
    {

        public ModelVendorItems()
        {

            Items = new List<ModelVendorItem>();

        }

        [XmlElement(ElementName = "item")]
        [DefaultValue(null)]
        public List<ModelVendorItem> Items { get; set; }

    }

}
