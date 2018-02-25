using System.Xml.Serialization;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Itemset model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "itemset")]
    public class ModelVendorItemset
    {

        public ModelVendorItemset()
        {

            Items = new ModelVendorItems();

        }

        [XmlElement(ElementName = "items")]
        public ModelVendorItems Items { get; set; }

        [XmlAttribute(AttributeName = "regionid")]
        public int Regionid { get; set; }

    }

}
