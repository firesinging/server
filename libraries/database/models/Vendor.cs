using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.vendor;
using Libraries.database.models.inventory;


namespace Libraries.database.models
{
    /// <summary>
    /// Vendor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "vendor")]
    public class ModelVendor
    {

        public ModelVendor()
        {

            Itemsets = new ModelVendorItemsets();

        }

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlElement(ElementName = "itemsets")]
        public ModelVendorItemsets Itemsets { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }        

    }

}
