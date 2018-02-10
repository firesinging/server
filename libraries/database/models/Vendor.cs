using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.vendor;


namespace Libraries.database.models
{
    /// <summary>
    /// Vendor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "vendor")]
    public class ModelVendor
    {

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlElement(ElementName = "itemsets")]
        public ModelVendorItemsets Itemsets { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
